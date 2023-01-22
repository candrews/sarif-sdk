﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Threading;

namespace Microsoft.CodeAnalysis.Sarif
{
    public interface IAnalysisContext : IDisposable
    {
        CancellationToken CancellationToken { get; set; }

        IArtifactProvider ScanTargetsProvider { get; set; }

        IEnumeratedArtifact CurrentScanTarget { get; set; }

        ISet<string> TargetFileSpecifiers { get; set; }
        
        ISet<FailureLevel> FailureLevels { get; set; }

        ISet<ResultKind> ResultKinds { get; set; }

        OptionallyEmittedData DataToInsert { get; set; }

        bool Recurse { get; set; }

        int Threads { get; set; }


        // TBD delete this.
        Uri TargetUri { get; set; }

        string MimeType { get; set; }

        HashData Hashes { get; set; }

        Exception TargetLoadException { get; set; }

        bool IsValidAnalysisTarget { get; }

        ReportingDescriptor Rule { get; set; }

        PropertiesDictionary Policy { get; set; }

        IAnalysisLogger Logger { get; set; }

        RuntimeConditions RuntimeErrors { get; set; }

        bool AnalysisComplete { get; set; }

        ISet<string> Traces { get; set; }

        long MaxFileSizeInKilobytes { get; set; }
    }
}
