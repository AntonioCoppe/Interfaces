# C# Interfaces Resources

This repository contains sample code and additional resources for the "C# Interfaces" course by Jeremy Clark on Pluralsight. The examples in the course use .NET 6.0  

## Code Samples

The code samples are in folders starting with the environment (net50), followed by the course module (module1). From there, the "before" and "after" folders contain the code at the beginning of the demo and the code at the end of the demo, respectively.

## Running the Samples

The code samples can be followed using Visual Studio (Windows) or Visual Studio Code (Windows, Linux, macOS).

***.NET 6.0 - development tool options***

* Visual Studio 2022 (Community Edition)  
* Visual Studio Code  

### Visual Studio 2022

When using Visual Studio, open the solution file (.sln) that is included in each sample folder. The solution is set up to automatically start the web application as well as the required web service, so no special action should be required.

**Running the Web Service and Application**  
To run a project, click F5 or use "Start debugging" from the toolbar or Debug menu.

Your default browser will automatically open to <http://localhost:5000> (the location of the web application). When you are done, close the browser window.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Note: If you get the following error:*

```bash
'No connection could be made because the target machine actively refused it. [::ffff:127.0.0.1]:9874 (localhost:9874)'
```

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Then the web service is not running. Check the [Troubleshooting Guide](/TroubleShooting.md) for help.*

**Running the Unit Tests**  
For the sample that has unit tests, open the Test Explorer in Visual Studio by selection "Test | Test Explorer" from the menu or "Ctrl+E, T".

In the Test Explorer, click the left-most button (or use "Ctrl+R, V") to run all of the tests.

### Visual Studio Code

When using Visual Studio Code, you will need to start the web service project separately from the web application.

**Starting the Service**  
For the projects that have a "People.Service" folder, use the following steps to start the service:

1. Open a terminal in the "People.Service" folder.
2. Type "dotnet run". (This will rebuild the project if necessary.)
3. The service should start and show the following info:

```bash
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:9874
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
```

If you open a browser to <http://localhost:9874/people>, you will see data from the service.

You can leave this terminal open for all of the samples; each sample uses the same web service.

To stop the service, press "Ctrl+C" in the terminal.

**Running the Web Application**  
To run the web application (PeopleViewer), use the following steps:

1. Open a terminal in the "PeopleViewer" folder.
2. Type "dotnet run". (This will rebuild the project if necessary.)
3. The web application should start and show the following info:

```bash
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
```

To run the application, open a browser to <http://localhost:5000>.

When you are done, you can stop the web server by going back to the terminal window and pressing "Ctrl+C".

Alternately, you can run the web application from within Visual Studio Code by using the integrated debugger. For more information, see [Visual Studio Code - Debugging](https://code.visualstudio.com/docs/editor/debugging).

**Running the Unit Tests**  
One of the samples includes unit testing. To run unit tests from the terminal, use the following steps:

1. Open a terminal in the "PeopleViewer.Tests" folder.
2. Type "dotnet test". (This will rebuild the project if necessary.)
3. The tests will run and the result will be similar to the following:

```bash
Test run for ...\PeopleViewer.Test.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.4
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     2, Skipped:     0, Total:     2, Duration: 60 ms - PeopleViewer.Test.dll (net5.0)
```

## Folders and Program

### 1 - Course Overview

### 2 - Introducing Interfaces

### 3 - Creating Interfaces to Add Extensibility

### 4 - Dynamic Loading and Unit Testing

### 5 - Explicit Interface Implementation

### 6 - Default Implementation and Advanced Topics
