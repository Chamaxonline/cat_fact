# cat_fact
This solution contains Dotnet Core Web API and Next Js frontend application. 
## Dotnet Core API 
API solution has two main layers Web API & class library.
API is having one controller with only one endpoint. Controller calls the client service to get 
real-time data from third-party API.

## Steps to Run in local

###  + First clone the solution in your local machine

###  + Run the backend without Visual Studio:  
     	Go to the src => backend => WebAPI  and open Powershell and run this command "dotnet run" 
 Then the backend solution will run automatically. 
You can check it by browser with accessing below url
<https://localhost:5001/swagger/index.html>

### + Run backend from Visual Studio : 
     	Go to the src => backend  folder and open the "CatFact" solution from visual studio. 
Then run the solution.Then it will automatically open the below url.
	
<https://localhost:5001/swagger/index.html>

### + Run the frontend: 
	Go to the src => froentend=> catlover  and open Powershell run this command "npm install"
 
	Then it will install all the node modules. After finishing that step run the below command 
	"npm run dev"  then browse the below url

<http://localhost:3000/>
	
	Then you can access the Cats facts. Click he green color button to get new facts.


