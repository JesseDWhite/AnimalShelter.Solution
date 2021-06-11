# _Blind Cat Rescue_ 🐱‍🏍
#### _This is our 13th week project for Epicodus that covers the basics of creating an API._
#### By _Jesse White_
## Technologies Used
* _C#_ 🆒
* _.NET_ 🥅
* _MySql_ 💽
* _Entity Framework_ 🎞
* _Swagger_ 📄
## Description 📜
_Blind Cat Rescue takes in all types of animals, but has a soft spot for blind cats. Use this API to access their inventory of current adoptable animals._
## Setup and Use 🏗

### Prerequisites 💻

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to run and interact with the console app.
- [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)

### Installation

1. Clone the repository: `$ git clone {https://github.com/JesseDWhite/AnimalShelter.Solution}`
2. Navigate to the `{AnimalShelter.Solution}` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup a SQL database using MySQL:
   - Create an `appsettings.json` file in the `{AnimalShelter}` directory
   - Copy the text box below and paste into the `appsettings.json` file, replacing `<password>` with your MySQL password:
   ```
     {
        "ConnectionStrings": {
           "DefaultConnection": "Server=localhost;Port=3306;database=jesse_white;uid=root;pwd=<password>;"
         }
     }
   ```
   - Open your terminal and run the command: `mysql -uroot -p<mysql_password>` (replace `<mysql_password>` with your MySQL password) and select the enter key to launch MySQL servers
5. To run the console app:
 - Navigate to `{AnimalShelter.Solution/AnimalShelter}` in your command line
   - Run the commands:
     - `dotnet restore` to restore the dependencies that are listed in `{AnimalShelter.csproj}`
     - `dotnet ef migrations add Initial` and `dotnet ef database update`
   - Finally, run the command `dotnet run` to run the project!
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
6. Visit the application via web browser at: `http://localhost:5004/`

### Documentation and Routes
1. To access the Swagger Documentation for API calls for GET, PUT, and POST please see below:
 - Run the application within `{AnimalShelter.Solution/AnimalShelter}` in your command line.
 - Once the application is running access the swagger documentation for API calls, go to `http://localhost:5004/index.html`
    - You can also follow this link while the program is running [Swagger](http://localhost:5004/index.html).
## Known Bugs 🐛
* _There are no known bugs_
## License ⚖
_MIT © Jesse White 2021_
## Contact Information 🤳
Jesse White _jesse.white6@gmail.com_