﻿namespace Lunar.PortableExecutable.Records;

internal sealed record ImportDescriptor(IEnumerable<ImportedFunction> Functions, string Name);