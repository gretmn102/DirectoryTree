# DirectoryTree
This is console application that builds a tree from the files and folders of the specified folder. For example:

```
dirtree E:\Project\DirectoryTree\src\bin\Debug\netcoreapp3.1
```

It will print this tree:

```
netcoreapp3.1
├─cs
│ └─FSharp.Core.resources.dll
├─de
│ └─FSharp.Core.resources.dll
├─es
│ └─FSharp.Core.resources.dll
├─fr
│ └─FSharp.Core.resources.dll
├─it
│ └─FSharp.Core.resources.dll
├─ja
│ └─FSharp.Core.resources.dll
├─ko
│ └─FSharp.Core.resources.dll
├─pl
│ └─FSharp.Core.resources.dll
├─pt-BR
│ └─FSharp.Core.resources.dll
├─ru
│ └─FSharp.Core.resources.dll
├─runtimes
│ ├─unix
│ │ └─lib
│ │   └─netcoreapp3.1
│ │     └─System.Drawing.Common.dll
│ └─win
│   └─lib
│     └─netcoreapp3.1
│       ├─Microsoft.Win32.SystemEvents.dll
│       └─System.Drawing.Common.dll
├─tr
│ └─FSharp.Core.resources.dll
├─zh-Hans
│ └─FSharp.Core.resources.dll
├─zh-Hant
│ └─FSharp.Core.resources.dll
├─FParsec.dll
├─FParsecCS.dll
├─FSharp.Core.dll
├─FSharp.Core.xml
├─FsharpMyExtension.dll
├─Fuchu.dll
├─HtmlAgilityPack.dll
├─Microsoft.Extensions.DependencyInjection.Abstractions.dll
├─Microsoft.Win32.SystemEvents.dll
├─Newtonsoft.Json.Bson.dll
├─Newtonsoft.Json.dll
├─Project.deps.json
├─Project.dll
├─Project.exe
├─Project.pdb
├─Project.runtimeconfig.dev.json
├─Project.runtimeconfig.json
├─System.Drawing.Common.dll
├─TextCopy.dll
└─YamlDotNet.dll
```

## Build
You need at least version 6.0.202 of dotnet, which can be downloaded [here](https://dotnet.microsoft.com/en-us/download).

```
dotnet tool restore
dotnet paket install
dotnet build
```
