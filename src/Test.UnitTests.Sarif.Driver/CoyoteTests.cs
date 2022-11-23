﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Coyote;
using Microsoft.Coyote.Specifications;
using Microsoft.Coyote.SystematicTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace Microsoft.CodeAnalysis.Sarif.Driver
{
    [TestClass]
    public class CoyoteTests
    {
        public Task AnalyzeCommandBase_ShouldGenerateSameResultsWhenRunningSingleAndMultiThread_CoyoteHelper()
        {
            Coyote.Random.Generator random = Coyote.Random.Generator.Create();
            int numScenarios = random.NextInteger(10) + 1;
            int[] scenarios = new int[] { numScenarios };

            AnalyzeCommandBaseTests.AnalyzeCommandBase_ShouldGenerateSameResultsWhenRunningSingleAndMultiThread(scenarios);

            return Task.CompletedTask;
        }

        [TestMethod, TestCategory("Coyote")]
        public void CoyoteTest_ShouldGenerateSameResultsWhenRunningSingleAndMultiThread()
        {
            RunSystematicTest(AnalyzeCommandBase_ShouldGenerateSameResultsWhenRunningSingleAndMultiThread_CoyoteHelper);
        }

        private static void RunSystematicTest(Func<Task> test, string reproducibleScheduleFilePath = null)
        {
            // Configuration for how to run a concurrency unit test with Coyote.
            // This configuration will run the test 1000 times exploring different paths each time.
            Configuration config = Configuration
                .Create()
                .WithTestingIterations(10000)
                .WithPartiallyControlledConcurrencyAllowed()
                .WithVerbosityEnabled(Coyote.Logging.VerbosityLevel.Debug);

            if (reproducibleScheduleFilePath != null)
            {
                string trace = File.ReadAllText(reproducibleScheduleFilePath);
                config = config.WithReproducibleTrace(trace);
            }

            async Task TestActionAsync()
            {
                await test();
            };

            var testingEngine = TestingEngine.Create(config, TestActionAsync);

            try
            {
                testingEngine.Run();

                string assertionText = testingEngine.TestReport.GetText(config);
                assertionText +=
                    $"{Environment.NewLine} Random Generator Seed: " +
                    $"{testingEngine.TestReport.Configuration.RandomGeneratorSeed}{Environment.NewLine}";
                foreach (string bugReport in testingEngine.TestReport.BugReports)
                {
                    assertionText +=
                    $"{Environment.NewLine}" +
                    "Bug Report: " + bugReport.ToString(CultureInfo.InvariantCulture);
                }

                if (testingEngine.TestReport.NumOfFoundBugs > 0)
                {
                    string timeStamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH-mm-ssZ", CultureInfo.InvariantCulture);
                    string reproducibleTraceFileName = $"buggy-{timeStamp}.schedule";
                    assertionText += Environment.NewLine + "Reproducible trace which leads to the bug can be found at " +
                        $"{Path.Combine(Directory.GetCurrentDirectory(), reproducibleTraceFileName)}";

                    File.WriteAllText(reproducibleTraceFileName, testingEngine.ReproducibleTrace);
                }

                Assert.IsTrue(testingEngine.TestReport.NumOfFoundBugs == 0, assertionText);

                Console.WriteLine(testingEngine.TestReport.GetText(config));
            }
            finally
            {
                testingEngine.Stop();
            }
        }

    }
}