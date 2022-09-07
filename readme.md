# **Simple WebApiProject in C#/.NET**
## Run instructions

This program calculates the distance between a fake client/person's postcode location (just in the UK!!!) and Heathrow airport and returns it in kilometers and miles, fetching data from an [external WebAPI](https://api.postcodes.io/).

It accepts one [postcode from the UK](https://ukpostcode.org/) as argument (case insensitive) for execution (avoid whitespaces).
<br></br>

In order to be able to run it, you need the .NET framework installed on your system. [Click here to check how to install it](https://docs.microsoft.com/en-us/dotnet/core/install).

### **Windows CMD**

- Open *Windows CMD* and go to *release(.exe)* folder using `cd [path to release(.exe)`.
- Type `WebApiProject.exe [postcode_without_whitespaces]`.
- Enjoy!
<br></br>

### **Windows PowerShell**

- Open *Windows PowerShell* and go to *release(.exe)* folder using `cd [path to release(.exe)`.
- Type `./WebApiProject.exe [postcode_without_whitespaces]`.
- Enjoy!
<br></br>

For Windows I also recommend using [GitBash](https://git-scm.com/downloads).

<br></br>

### **GNU/Linux and MacOS**

- For **Debian/Ubuntu based distros** I'd recommend you install *dotnet* via ***apt package manager*** rather than via *snap*:

`sudo apt update`

`apt-cache search dotnet`

Install the latest *dotnet sdk* (or just the runtime environment). For example, for ***sdk6.0***:

`sudo apt install dotnet-sdk6.0`

- For **other GNU/Linux distros** or **MacOS**, [check the instructions for installation from the official website from Microsoft](https://docs.microsoft.com/en-us/dotnet/core/install).

- Open your *UNIX-Like command line terminal* inside of the cloned/downloaded directory *Csharp_dotnet_WebAPiProject*, then: `cd WebApiProject` .
- Type: `dotnet run [postcode_without_whitespaces]`.
- Enjoy!

<br></br>

### **VS Code**

- Open the downloaded folder/project in VS Code ([You need to install *dotnet*](https://docs.microsoft.com/en-us/dotnet/core/install/)).
- Open a terminal and run the following command `cd .\WebApiProject\`.
- Then type: `dotnet run [postcode_without_whitespaces]`.
- Enjoy!
<br></br>
___

### **Example** (Git Bash)

<img src="resources\Windows_GitBash_example.png" alt="GitBash Example">



___
Author: [Fernando Tona](https://www.linkedin.com/in/fernandotona/)
