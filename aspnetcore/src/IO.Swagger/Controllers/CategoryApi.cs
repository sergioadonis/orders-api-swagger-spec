/*
 * Restaurant Orders
 *
 * Simple API to manage restaurant orders
 *
 * OpenAPI spec version: v1
 * Contact: sergio.adonis@outlook.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class CategoryApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="0">ok</response>
        [HttpPost]
        [Route("/sergioadonis/restaurant-orders-api/v1/categories")]
        [ValidateModelState]
        [SwaggerOperation("AddCategory")]
        [SwaggerResponse(statusCode: 0, type: typeof(CategoryObjectResult), description: "ok")]
        public virtual IActionResult AddCategory([FromBody]Category body)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(CategoryObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"category\" : {\n      \"restaurants\" : [ {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      }, {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      } ]\n    }\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CategoryObjectResult>(exampleJson)
                        : default(CategoryObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpDelete]
        [Route("/sergioadonis/restaurant-orders-api/v1/categories/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteCategory")]
        [SwaggerResponse(statusCode: 0, type: typeof(CategoryObjectResult), description: "ok")]
        public virtual IActionResult DeleteCategory([FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(CategoryObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"category\" : {\n      \"restaurants\" : [ {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      }, {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      } ]\n    }\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CategoryObjectResult>(exampleJson)
                        : default(CategoryObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="skip"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/categories")]
        [ValidateModelState]
        [SwaggerOperation("GetCategories")]
        [SwaggerResponse(statusCode: 0, type: typeof(CategoryArrayResult), description: "ok")]
        public virtual IActionResult GetCategories([FromQuery]int? limit, [FromQuery]int? skip)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(CategoryArrayResult));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"categories\" : [ {\n      \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n      \"name\" : \"Name of object\",\n      \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n      \"id\" : 123\n    }, {\n      \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n      \"name\" : \"Name of object\",\n      \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n      \"id\" : 123\n    } ]\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CategoryArrayResult>(exampleJson)
                        : default(CategoryArrayResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/categories/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetCategoryById")]
        [SwaggerResponse(statusCode: 0, type: typeof(CategoryObjectResult), description: "ok")]
        public virtual IActionResult GetCategoryById([FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(CategoryObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"category\" : {\n      \"restaurants\" : [ {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      }, {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      } ]\n    }\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CategoryObjectResult>(exampleJson)
                        : default(CategoryObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpPut]
        [Route("/sergioadonis/restaurant-orders-api/v1/categories/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateCategory")]
        [SwaggerResponse(statusCode: 0, type: typeof(CategoryObjectResult), description: "ok")]
        public virtual IActionResult UpdateCategory([FromBody]Category body, [FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(CategoryObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"category\" : {\n      \"restaurants\" : [ {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      }, {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      } ]\n    }\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CategoryObjectResult>(exampleJson)
                        : default(CategoryObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
