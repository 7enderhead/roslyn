﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

using System;
using Microsoft.CodeAnalysis.ExpressionEvaluator;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;

namespace Microsoft.CodeAnalysis.CSharp.ExpressionEvaluator
{
    [DkmReportNonFatalWatsonException(ExcludeExceptionType = typeof(NotImplementedException)), DkmContinueCorruptingException]
    internal sealed class CSharpLanguageInstructionDecoder : LanguageInstructionDecoder<CSharpCompilation, MethodSymbol, PEModuleSymbol, TypeSymbol, TypeParameterSymbol, ParameterSymbol>
    {
        public CSharpLanguageInstructionDecoder()
            : base(CSharpInstructionDecoder.Instance)
        {
        }
    }
}
