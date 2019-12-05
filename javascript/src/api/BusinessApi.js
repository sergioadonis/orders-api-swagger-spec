/*
 * Orders API
 * Simple API to manage businesses and orders
 *
 * OpenAPI spec version: 1.0.1
 * Contact: sergio.adonis@outlook.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.10
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/Business', 'model/BusinessProps', 'model/InlineResponseDefault'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/Business'), require('../model/BusinessProps'), require('../model/InlineResponseDefault'));
  } else {
    // Browser globals (root is window)
    if (!root.OrdersApi) {
      root.OrdersApi = {};
    }
    root.OrdersApi.BusinessApi = factory(root.OrdersApi.ApiClient, root.OrdersApi.Business, root.OrdersApi.BusinessProps, root.OrdersApi.InlineResponseDefault);
  }
}(this, function(ApiClient, Business, BusinessProps, InlineResponseDefault) {
  'use strict';

  /**
   * Business service.
   * @module api/BusinessApi
   * @version 1.0.1
   */

  /**
   * Constructs a new BusinessApi. 
   * @alias module:api/BusinessApi
   * @class
   * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
   * default to {@link module:ApiClient#instance} if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the createOneBusiness operation.
     * @callback module:api/BusinessApi~createOneBusinessCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Business} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create business
     * @param {module:model/BusinessProps} businessProps 
     * @param {module:api/BusinessApi~createOneBusinessCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Business}
     */
    this.createOneBusiness = function(businessProps, callback) {
      var postBody = businessProps;

      // verify the required parameter 'businessProps' is set
      if (businessProps === undefined || businessProps === null) {
        throw new Error("Missing the required parameter 'businessProps' when calling createOneBusiness");
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Business;

      return this.apiClient.callApi(
        '/business', 'POST',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the deleteOneBusiness operation.
     * @callback module:api/BusinessApi~deleteOneBusinessCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Delete business
     * @param {String} businessId 
     * @param {module:api/BusinessApi~deleteOneBusinessCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.deleteOneBusiness = function(businessId, callback) {
      var postBody = null;

      // verify the required parameter 'businessId' is set
      if (businessId === undefined || businessId === null) {
        throw new Error("Missing the required parameter 'businessId' when calling deleteOneBusiness");
      }


      var pathParams = {
        'businessId': businessId
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = null;

      return this.apiClient.callApi(
        '/business/{businessId}', 'DELETE',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getBusinessesList operation.
     * @callback module:api/BusinessApi~getBusinessesListCallback
     * @param {String} error Error message, if any.
     * @param {Array.<module:model/Business>} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get businesses
     * @param {module:api/BusinessApi~getBusinessesListCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link Array.<module:model/Business>}
     */
    this.getBusinessesList = function(callback) {
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = [Business];

      return this.apiClient.callApi(
        '/business', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getOneBusiness operation.
     * @callback module:api/BusinessApi~getOneBusinessCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Business} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get business
     * @param {String} businessId 
     * @param {module:api/BusinessApi~getOneBusinessCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Business}
     */
    this.getOneBusiness = function(businessId, callback) {
      var postBody = null;

      // verify the required parameter 'businessId' is set
      if (businessId === undefined || businessId === null) {
        throw new Error("Missing the required parameter 'businessId' when calling getOneBusiness");
      }


      var pathParams = {
        'businessId': businessId
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Business;

      return this.apiClient.callApi(
        '/business/{businessId}', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the updateOneBusiness operation.
     * @callback module:api/BusinessApi~updateOneBusinessCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Business} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Update business
     * @param {String} businessId 
     * @param {module:model/BusinessProps} businessProps 
     * @param {module:api/BusinessApi~updateOneBusinessCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Business}
     */
    this.updateOneBusiness = function(businessId, businessProps, callback) {
      var postBody = businessProps;

      // verify the required parameter 'businessId' is set
      if (businessId === undefined || businessId === null) {
        throw new Error("Missing the required parameter 'businessId' when calling updateOneBusiness");
      }

      // verify the required parameter 'businessProps' is set
      if (businessProps === undefined || businessProps === null) {
        throw new Error("Missing the required parameter 'businessProps' when calling updateOneBusiness");
      }


      var pathParams = {
        'businessId': businessId
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Business;

      return this.apiClient.callApi(
        '/business/{businessId}', 'PUT',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
