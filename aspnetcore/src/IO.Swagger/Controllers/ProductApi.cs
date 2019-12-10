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
    public class ProductApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="0">ok</response>
        [HttpPost]
        [Route("/sergioadonis/restaurant-orders-api/v1/products")]
        [ValidateModelState]
        [SwaggerOperation("AddProduct")]
        [SwaggerResponse(statusCode: 0, type: typeof(ProductObjectResult), description: "ok")]
        public virtual IActionResult AddProduct([FromBody]Product body)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ProductObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"product\" : {\n      \"restaurant\" : {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      }\n    }\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ProductObjectResult>(exampleJson)
                        : default(ProductObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpDelete]
        [Route("/sergioadonis/restaurant-orders-api/v1/products/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteProduct")]
        [SwaggerResponse(statusCode: 0, type: typeof(ProductObjectResult), description: "ok")]
        public virtual IActionResult DeleteProduct([FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ProductObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"product\" : {\n      \"restaurant\" : {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      }\n    }\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ProductObjectResult>(exampleJson)
                        : default(ProductObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/products/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetProductById")]
        [SwaggerResponse(statusCode: 0, type: typeof(ProductObjectResult), description: "ok")]
        public virtual IActionResult GetProductById([FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ProductObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"product\" : {\n      \"restaurant\" : {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      }\n    }\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ProductObjectResult>(exampleJson)
                        : default(ProductObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="skip"></param>
        /// <param name="restaurant"></param>
        /// <param name="menu"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/products")]
        [ValidateModelState]
        [SwaggerOperation("GetProducts")]
        [SwaggerResponse(statusCode: 0, type: typeof(ProductArrayResult), description: "ok")]
        public virtual IActionResult GetProducts([FromQuery]int? limit, [FromQuery]int? skip, [FromQuery]CommonPropspropertiesid restaurant, [FromQuery]CommonPropspropertiesid menu)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ProductArrayResult));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"products\" : [ {\n      \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n      \"name\" : \"Name of object\",\n      \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n      \"id\" : 123\n    }, {\n      \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n      \"name\" : \"Name of object\",\n      \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n      \"id\" : 123\n    } ]\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ProductArrayResult>(exampleJson)
                        : default(ProductArrayResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpPut]
        [Route("/sergioadonis/restaurant-orders-api/v1/products/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateProduct")]
        [SwaggerResponse(statusCode: 0, type: typeof(ProductObjectResult), description: "ok")]
        public virtual IActionResult UpdateProduct([FromBody]Product body, [FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ProductObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"product\" : {\n      \"restaurant\" : {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      }\n    }\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ProductObjectResult>(exampleJson)
                        : default(ProductObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
