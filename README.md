# CSHARP LIBRARY
### The repository of the code of my programs in C#

---
### Compiling your C# code with Mono

To compile, use csc:
```
csc program.cs
```
The compiler will create **“program.exe”**, which you can run using:
```
mono program.exe
```
---
### Installing **.NET** and **Mono** on (Ubuntu  20.04)

Full information about **.NET** and **Mono** can be found at the [**link .NET**](https://docs.microsoft.com/en-us/dotnet/fundamentals/), [**link Mono**](https://www.mono-project.com/)

**To install the .NET SDK 5.0, run the command in a terminal:**
```sh
sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-5.0
```
**And to install Mono commands:**
```
sudo apt install mono-devel
```
---
### Installing the [JetBrains Rider](https://www.jetbrains.com/ru-ru/rider/) development environment on Ubuntu
<img align="right" width="230" height="140" src="https://user-images.githubusercontent.com/36339434/123662350-0d70cb80-d83e-11eb-9e44-9120fee0f228.png">

To do this, run the commands:
```
sudo apt update
sudo apt install snapd

sudo snap install rider --classic
```
---

