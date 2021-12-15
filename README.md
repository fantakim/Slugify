# Slugify
> Converts a string into a slug.

[![Nuget](https://img.shields.io/nuget/v/Sendbird)](https://www.nuget.org/packages/Sendbird)
[![.NET Standard](https://img.shields.io/badge/.NET%20Standard-%3E%3D%202.0-red.svg)](#)

## Description
Created by referring to https://github.com/simov/slugify 

## Prerequisites
- .NET Standard 2.0

## Installation
Using the [.NET Core command-line interface (CLI) tools]

```sh
dotnet add package Slugify
```

Using the [NuGet Command Line Interface (CLI)]

```sh
nuget install Slugify
```

Using the [Package Manager Console]

```powershell
Install-Package Slugify
```

## Usage
```c#
"Elon Musk considers move to Mars".GenerateSlug(); // elon-musk-considers-move-to-mars
"Fintech startups raised $34B in 2019".GenerateSlug(); // fintech-startups-raised-dollar34b-in-2019
```
