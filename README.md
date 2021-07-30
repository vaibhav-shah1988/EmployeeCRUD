# EmployeeCRUD
Employee CRUD operations using .Net 5 WEB API

	
1. https://localhost:44398/api/Account/register	
Type: POST
Request Body: 
{
  ""userName"": ""Vaibhav"",
  ""password"": ""Va@123456789"",
  ""email"": ""user@example.com""
}

Response:{
  ""status"": ""Success"",
  ""message"": ""User created successfully!""
}
			
			
2.  https://localhost:44398/api/Account/register-admin	
Type: POST
Request Body: 
{
  ""userName"": ""Vaibhav1"",
  ""password"": ""abc@V123"",
  ""email"": ""user@example.com""
}

Response:{
  ""status"": ""Success"",
  ""message"": ""User created successfully!""
}
			
3.  https://localhost:44398/api/Account/login	
Type: POST
Request: {
  ""userName"": ""Vaibhav1"",
  ""password"": ""abc@V123""
}
Response: 
Status Code-> 200
{
    ""token"": ""eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY"",
    ""expiration"": ""2021-07-30T22:25:28Z""
}

If Username or password is Wrong -> Status Code 401
			
4.  https://localhost:44398/api/Employee	(GET ALL Employees)
TYPE: GET

Header: 
Authentication: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY"

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
]
			
5.  https://localhost:44398/api/Employee/{Id}	
Type: GET

Header: 
Authentication: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY"

Response:{
  ""id"": 1,
  ""name"": ""Vaibhav"",
  ""age"": 30,
  ""skills"": ""C#"",
  ""depatmentId"": 1,
  ""department"": null
}
			
6.  https://localhost:44398/api/Employee/AddEmployee	Header: Authentication: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY"
Type: POST

Request: {
  ""id"": 0,
  ""name"": ""Vaibhav1"",
  ""age"": 32,
  ""skills"": ""C#,sql"",
  ""depatmentId"": 1
}

Response: Employee Created SuccessFully.
			
7.  https://localhost:44398/api/Employee/UpdateEmployee	
Type: PUT

Header: 
Authentication: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY"


Request: {
  ""id"": 2,
  ""name"": ""Vaibhav100"",
  ""age"": 30,
  ""skills"": ""C#,MVC"",
  ""depatmentId"": 2
}

Response: Employee Updated SuccessFully.
			
8.  https://localhost:44398/api/Employee/DeleteEmployee/{Id}	
Type: DELETE

Header: 
Authentication: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVmFpYmhhdjEiLCJqdGkiOiIxYjhkYzJlNi1jNTU2LTQxMTMtYmE1Ni0wYzU1MGEyOGFkMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYyNzY4MzkyOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.sxN2OB4eV250pHHc8PgHeLmW5NCk2nGxd8UEjupK-cY"

Response:Employee Deleted SuccessFully.
			
	<b>If role of logged in user is not Admin then user will get 401 error when trying to access APIs		</b>

