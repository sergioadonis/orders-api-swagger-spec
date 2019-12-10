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
    public class RestaurantApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="0">ok</response>
        [HttpPost]
        [Route("/sergioadonis/restaurant-orders-api/v1/restaurants")]
        [ValidateModelState]
        [SwaggerOperation("AddRestaurant")]
        [SwaggerResponse(statusCode: 0, type: typeof(RestaurantObjectResult), description: "ok")]
        public virtual IActionResult AddRestaurant([FromBody]Restaurant body)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(RestaurantObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"restaurant\" : {\n    \"menus\" : [ {\n      \"restaurantId\" : 123\n    }, {\n      \"restaurantId\" : 123\n    } ],\n    \"category\" : \"\",\n    \"products\" : [ {\n      \"price\" : 0.8008281904610115,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    }, {\n      \"price\" : 0.8008281904610115,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    } ]\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<RestaurantObjectResult>(exampleJson)
                        : default(RestaurantObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpDelete]
        [Route("/sergioadonis/restaurant-orders-api/v1/restaurants/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteRestaurant")]
        [SwaggerResponse(statusCode: 0, type: typeof(RestaurantObjectResult), description: "ok")]
        public virtual IActionResult DeleteRestaurant([FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(RestaurantObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"restaurant\" : {\n    \"menus\" : [ {\n      \"restaurantId\" : 123\n    }, {\n      \"restaurantId\" : 123\n    } ],\n    \"category\" : \"\",\n    \"products\" : [ {\n      \"price\" : 0.8008281904610115,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    }, {\n      \"price\" : 0.8008281904610115,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    } ]\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<RestaurantObjectResult>(exampleJson)
                        : default(RestaurantObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/restaurants/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetRestaurantById")]
        [SwaggerResponse(statusCode: 0, type: typeof(RestaurantObjectResult), description: "ok")]
        public virtual IActionResult GetRestaurantById([FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(RestaurantObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"restaurant\" : {\n    \"menus\" : [ {\n      \"restaurantId\" : 123\n    }, {\n      \"restaurantId\" : 123\n    } ],\n    \"category\" : \"\",\n    \"products\" : [ {\n      \"price\" : 0.8008281904610115,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    }, {\n      \"price\" : 0.8008281904610115,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    } ]\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<RestaurantObjectResult>(exampleJson)
                        : default(RestaurantObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="skip"></param>
        /// <param name="categoryId"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/restaurants")]
        [ValidateModelState]
        [SwaggerOperation("GetRestaurants")]
        [SwaggerResponse(statusCode: 0, type: typeof(RestaurantArrayResult), description: "ok")]
        public virtual IActionResult GetRestaurants([FromQuery]int? limit, [FromQuery]int? skip, [FromQuery]CommonPropspropertiesid categoryId)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(RestaurantArrayResult));
            string exampleJson = null;
            exampleJson = "{\n  \"restaurants\" : [ {\n    \"address\" : {\n      \"country\" : \"country\",\n      \"city\" : \"city\",\n      \"description\" : \"description\",\n      \"state\" : \"state\",\n      \"line2\" : \"line2\",\n      \"line1\" : \"line1\"\n    },\n    \"geoLocation\" : {\n      \"latitud\" : 0,\n      \"longitud\" : 6\n    },\n    \"contact\" : {\n      \"whatsapp\" : \"7788-9900\",\n      \"phoneNumber\" : \"2222-5555\",\n      \"facebook\" : \"facebook\",\n      \"email\" : \"correo@ejemplo.com\"\n    },\n    \"schedules\" : [ {\n      \"name\" : \"name\",\n      \"closeTime\" : \"closeTime\",\n      \"days\" : \"days\",\n      \"openTime\" : \"openTime\"\n    }, {\n      \"name\" : \"name\",\n      \"closeTime\" : \"closeTime\",\n      \"days\" : \"days\",\n      \"openTime\" : \"openTime\"\n    } ],\n    \"categoryId\" : 123,\n    \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n  }, {\n    \"address\" : {\n      \"country\" : \"country\",\n      \"city\" : \"city\",\n      \"description\" : \"description\",\n      \"state\" : \"state\",\n      \"line2\" : \"line2\",\n      \"line1\" : \"line1\"\n    },\n    \"geoLocation\" : {\n      \"latitud\" : 0,\n      \"longitud\" : 6\n    },\n    \"contact\" : {\n      \"whatsapp\" : \"7788-9900\",\n      \"phoneNumber\" : \"2222-5555\",\n      \"facebook\" : \"facebook\",\n      \"email\" : \"correo@ejemplo.com\"\n    },\n    \"schedules\" : [ {\n      \"name\" : \"name\",\n      \"closeTime\" : \"closeTime\",\n      \"days\" : \"days\",\n      \"openTime\" : \"openTime\"\n    }, {\n      \"name\" : \"name\",\n      \"closeTime\" : \"closeTime\",\n      \"days\" : \"days\",\n      \"openTime\" : \"openTime\"\n    } ],\n    \"categoryId\" : 123,\n    \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<RestaurantArrayResult>(exampleJson)
                        : default(RestaurantArrayResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpPut]
        [Route("/sergioadonis/restaurant-orders-api/v1/restaurants/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateRestaurant")]
        [SwaggerResponse(statusCode: 0, type: typeof(RestaurantObjectResult), description: "ok")]
        public virtual IActionResult UpdateRestaurant([FromBody]Restaurant body, [FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(RestaurantObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"restaurant\" : {\n    \"menus\" : [ {\n      \"restaurantId\" : 123\n    }, {\n      \"restaurantId\" : 123\n    } ],\n    \"category\" : \"\",\n    \"products\" : [ {\n      \"price\" : 0.8008281904610115,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    }, {\n      \"price\" : 0.8008281904610115,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    } ]\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<RestaurantObjectResult>(exampleJson)
                        : default(RestaurantObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
