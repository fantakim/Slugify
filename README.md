# SlugifyNet
> Converts a string into a slug.

[![Nuget](https://img.shields.io/nuget/v/SlugifyNet)](https://www.nuget.org/packages/SlugifyNet)
[![.NET Standard](https://img.shields.io/badge/.NET%20Standard-%3E%3D%202.0-red.svg)](#)

## Description
Created by referring to https://github.com/simov/slugify 

## Prerequisites
- .NET Standard 2.0

## Installation
Using the [.NET Core command-line interface (CLI) tools]

```sh
dotnet add package SlugifyNet
```

Using the [NuGet Command Line Interface (CLI)]

```sh
nuget install SlugifyNet
```

Using the [Package Manager Console]

```powershell
Install-Package SlugifyNet
```

## Usage
```c#
"Elon Musk considers move to Mars".GenerateSlug(); // elon-musk-considers-move-to-mars
"Fintech startups raised $34B in 2019".GenerateSlug(); // fintech-startups-raised-dollar34b-in-2019
```
## Slugify Examples
| Web Page Title | SEO-friendly URL Slug |
|--|--|
| Best Practices and Considerations for Multilingual Sites | best-practices-and-considerations-for-multilingual-sites |
| Meilleures pratiques et considérations relatives aux sites multilingues | meilleures-pratiques-et-considerations-relatives-aux-sites-multilingues |
| Bewährte Vorgehensweisen und Überlegungen für mehrsprachige Sites | bewahrte-vorgehensweisen-und-uberlegungen-fur-mehrsprachige-sites |
| Considerazioni e procedure consigliate per i siti multilingue | considerazioni-e-procedure-consigliate-per-i-siti-multilingue |
| マルチ言語サイトのベストプラクティスと考慮事項 | マルチ言語サイトのベストプラクティスと考慮事項 |
| Prácticas recomendadas y consideraciones para sitios multilingüe | practicas-recomendadas-y-consideraciones-para-sitios-multilingue |
| 多语言站点的最佳实践和注意事项 | 多语言站点的最佳实践和注意事项 |
| 다국어 사이트에 대한 모범 사례 및 고려 사항 | 다국어-사이트에-대한-모범-사례-및-고려-사항 |
| Советы и рекомендации для многоязычных сайтов | sovety-i-rekomendacii-dlya-mnogoyazychnyh-sajtov |
| Melhores práticas e considerações para sites multilíngues | melhores-praticas-e-consideracoes-para-sites-multilingues |
| Các phương pháp hay nhất và cân nhắc cho các trang web đa ngôn ngữ | cac-phuong-phap-hay-nhat-va-can-nhac-cho-cac-trang-web-dja-ngon-ngu |
| แนวปฏิบัติที่ดีที่สุดและข้อควรพิจารณาสำหรับไซต์หลายภาษา | แนวปฏิบัติที่ดีที่สุดและข้อควรพิจารณาสำหรับไซต์หลายภาษา |
