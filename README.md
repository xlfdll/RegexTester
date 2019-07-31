# .NET Regular Expression Tester
A regular expression tester with tree-based result view

<p align="center">
  <img src="https://github.com/xlfdll/xlfdll.github.io/raw/master/images/projects/RegexTester/RegexTester-Main.png"
       alt=".NET Regular Expression Tester - Main Window" width="720">
</p>

## System Requirements
* .NET Framework 4.7.2

[Runtime configuration](https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/how-to-configure-an-app-to-support-net-framework-4-or-4-5) is needed for running on other versions of .NET Framework.

## Usage
1. **Load Text** from file or Web, or simply type / paste text into Text area
2. Fill in regular expression and replacement expression (optional, for text replacement)
   * Use **Edit Pattern** <img src="https://github.com/xlfdll/xlfdll.github.io/raw/master/images/projects/RegexTester/RegexTester-EditPattern.png" alt="Edit Pattern" width="32"> button for multiline pattern editing if necessary
3. Choose appropriate [RegexOptions](https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-options)
4. Click one of the following buttons in the toolbar:
   * **Match**: To perform regular expression search on input text
   * **Split**: To split input text based on specific regular expression
   * **Replace**: To perform replacement based on specific regular expression and replacement expression
   * **Measure**: To measure regular expression search performance
   
   <p align="center">
       <img src="https://github.com/xlfdll/xlfdll.github.io/raw/master/images/projects/RegexTester/RegexTester-Measure.png"
            alt=".NET Regular Expression Tester - Time Measurement">
   </p>
   
5. Expand and check results in Result pane
6. Use job operations (**Save Job [As]**, **Open Job**, etc.) to save current working state for further reuse

## Development Prerequisites
* Visual Studio 2015+

Before the build, generate-build-number.sh needs to be executed in a Git / Bash shell to generate build information code file (BuildInfo.cs).

## External Sources
Icons are from [Modern UI Icons](http://modernuiicons.com/), which are licensed under [CC BY-ND 3.0](https://github.com/Templarian/WindowsIcons/blob/master/WindowsPhone/license.txt).
