# Owoify.Net
Turning your worst nightmare into a NuGet package.

[![Build Status](https://travis-ci.org/deadshot465/Owoify.Net.svg?branch=master)](https://travis-ci.org/github/deadshot465/Owoify.Net)

- [NuGet package](https://www.nuget.org/packages/Owoify.Net/1.0.1)

This is a C# port of [mohan-cao's owoify-js](https://github.com/mohan-cao/owoify-js), which will help you turn any string into nonsensical babyspeak similar to LeafySweet's infamous Chrome extension. Just like owoify-js, three levels are available for owoifying your texts:

1. **owo (default):** The most vanilla one.
2. **uwu:** The moderate one.
3. **uvu:** Litewawwy unweadabwal.

Please refer to the original [owoify-js repository](https://github.com/mohan-cao/owoify-js) for more information.

## Install instructions

Install via [NuGet Package Explorer](https://github.com/NuGetPackageExplorer/NuGetPackageExplorer) or Visual Studio's built-in NuGet package manager. Alternatively, run the following command in the root directory of your project:

```bash
dotnet add package Owoify.Net --version 1.0.1
```

## Usage

```c#
using Owoify;

// Without specifying owoify level. Default to owo.
Console.WriteLine(Owoifier.Owoify("This is the string to owo! Kinda cute isn't it?"));

// Specifying owoify level as uvu.
Console.WriteLine(Owoifier.Owoify("This is the string to owo! Kinda cute isn't it?", Owoifier.OwoifyLevel.Uvu));

// Output:
// This is teh stwing two owo! Kinda cute isn't it?
// fwis is teh stwing two owowowo ＼(＾▽＾)／ Kinda cute isn't it?
```

