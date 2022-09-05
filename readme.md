# **Simple WebApiProject in C#/.NET**
## Run instructions

This program calculates the distance between a fake client/person's postcode location (just in the UK!!!) and Heathrow airport and returns it in kilometers and miles, connecting to an [external WebAPI](https://api.postcodes.io/).

It accepts one [postcode from the UK](https://ukpostcode.org/) as argument (case insensitive) for execution (avoid whitespaces).
<br></br>

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

### **GNU/Linux and MacOS**

- You need *dotnet* installed in your system. [Check here how to install it if you haven't installed it yet](https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu).
- For Debian/Ubuntu based distros I'd recommend you install *dotnet* via *apt package manager* rather than via *snap*:

`sudo apt update`

`apt-cache search dotnet`

Install the latest *dotnet sdk* (or just runtime). For example, for ***sdk6.0***:

`sudo apt install dotnet-sdk6.0`

- Open your *UNIX command line terminal* inside of the cloned/downloaded directory *Csharp_dotnet_WebAPiProject*, then: `cd WebApiProject` .
- Type `dotnet run [postcode_without_whitespaces]`.
- Enjoy!

### **VS Code**

- Open the downloaded folder/project in VS Code ([You need to install *dotnet*](https://docs.microsoft.com/en-us/dotnet/core/install/)).
- Open a terminal and run the following command `cd .\WebApiProject\`.
- Then type `dotnet run [postcode_without_whitespaces]`.
- Enjoy!

___
Author: [Fernando Tona](https://www.linkedin.com/in/fernandotona/)
