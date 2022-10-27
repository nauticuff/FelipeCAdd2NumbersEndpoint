/*
Carlos Felipe 
10/25/22
Add 2 Numbers - Endpoint
CODE: This program adds two numbers and displays their sum on screen throguh URL user input
Peer review by Jasmine Leek - works great, code is clearly written. good work!
*/
using Microsoft.AspNetCore.Mvc;

namespace FelipeCAdd2NumberesEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Add2NumbersController : ControllerBase
{
    
    [HttpGet]
    [Route("Add/{numOne}/{numTwo}")]
    public int Add(string numOne, string numTwo){ 
        int intOne = Convert.ToInt32(numOne); 
        int intTwo = Convert.ToInt32(numTwo); 
        return intOne + intTwo; 
    } 
}
