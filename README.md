# EmployeeCRUD
Employee CRUD operations using .Net 5 WEB API

<h2>Tools Used</h2>
<ul>
	<li>Visual Studio 2019</li>
	<li>SQL Server 2014</li>
</ul>
<hr/>

<h2>Database Setup</h2>
<ul>
	<li>Change connection string in application.json file</li>
	<li>Use "update-database" command to create new database</li>
	<li>Add 2-3 departments in Department table</li>
</ul>

<hr/>

<h2> APIs </h2>

1. https://localhost:44398/api/Account/register	<br/>
Type: POST <br/>
Request Body: 
{
  ""userName"": ""Vaibhav"",
  ""password"": ""Va@123456789"",
  ""email"": ""user@example.com""
} <br/>
Response:{
  ""status"": ""Success"",
  ""message"": ""User created successfully!""
}


2.  https://localhost:44398/api/Account/register-admin	 <br/>
Type: POST <br/>
Request Body: 
{
  ""userName"": ""Vaibhav1"",
  ""password"": ""abc@V123"",
  ""email"": ""user@example.com""
} <br/>
Response:{
  ""status"": ""Success"",
  ""message"": ""User created successfully!""
}
			
3.  https://localhost:44398/api/Account/login	 <br/>
Type: POST  <br/>
Request: {
  ""userName"": ""Vaibhav1"",
  ""password"": ""abc@V123""
} <br/>
Response: 
Status Code-> 200 <br/>
{
    ""token"": ""eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY"",
    ""expiration"": ""2021-07-30T22:25:28Z""
}<br/>
If Username or password is Wrong -> Status Code 401
			
4.  https://localhost:44398/api/Employee	(GET ALL Employees) <br/>
TYPE: GET <br/>
Header: <br/>
Authentication: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY" <br/>
Response:[
  {
    ""id"": 2,
    ""name"": ""Vaibhav"",
    ""age"": 30,
    ""skills"": ""C#"",
    ""depatmentId"": 1,
    ""department"": null
  },
  {
    ""id"": 3,
    ""name"": ""Vaibhav1"",
    ""age"": 32,
    ""skills"": ""C#,sql"",
    ""depatmentId"": 1,
    ""department"": null
  }
] <br/>
			
5.  https://localhost:44398/api/Employee/{Id}	 <br/>
Type: GET <br/>
Header:  <br/>
Authentication: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY" <br/>
Response:{
  ""id"": 1,
  ""name"": ""Vaibhav"",
  ""age"": 30,
  ""skills"": ""C#"",
  ""depatmentId"": 1,
  ""department"": null
} <br/>
			
6.  https://localhost:44398/api/Employee/AddEmployee	<br/>
Type: POST <br/>
Header: <br/>
Authentication: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY" <br/>
Request: {
  ""id"": 0,
  ""name"": ""Vaibhav1"",
  ""age"": 32,
  ""skills"": ""C#,sql"",
  ""depatmentId"": 1
} <br/>
Response: Employee Created SuccessFully. <br/>
			
7.  https://localhost:44398/api/Employee/UpdateEmployee	 <br/>
Type: PUT <br/>
Header:  <br/>
Authentication: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY" <br/>
Request: {
  ""id"": 2,
  ""name"": ""Vaibhav100"",
  ""age"": 30,
  ""skills"": ""C#,MVC"",
  ""depatmentId"": 2
} <br/>
Response: Employee Updated SuccessFully. <br/>
			
8.  https://localhost:44398/api/Employee/DeleteEmployee/{Id}	 <br/>
Type: DELETE <br/>
Header:  <br/>
Authentication: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY" <br/>
Response:Employee Deleted SuccessFully. <br/>

<h4>If role of logged in user is not Admin then user will get 401 error when trying to access APIs</h4>

