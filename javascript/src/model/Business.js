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
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.OrdersApi) {
      root.OrdersApi = {};
    }
    root.OrdersApi.Business = factory(root.OrdersApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The Business model module.
   * @module model/Business
   * @version 1.0.1
   */

  /**
   * Constructs a new <code>Business</code>.
   * @alias module:model/Business
   * @class
   * @param name {String} 
   */
  var exports = function(name) {
    this.name = name;
  };

  /**
   * Constructs a <code>Business</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Business} obj Optional instance to populate.
   * @return {module:model/Business} The populated <code>Business</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('id'))
        obj.id = ApiClient.convertToType(data['id'], 'String');
      if (data.hasOwnProperty('name'))
        obj.name = ApiClient.convertToType(data['name'], 'String');
      if (data.hasOwnProperty('description'))
        obj.description = ApiClient.convertToType(data['description'], 'String');
      if (data.hasOwnProperty('category'))
        obj.category = ApiClient.convertToType(data['category'], 'String');
      if (data.hasOwnProperty('tags'))
        obj.tags = ApiClient.convertToType(data['tags'], ['String']);
      if (data.hasOwnProperty('photoUrl'))
        obj.photoUrl = ApiClient.convertToType(data['photoUrl'], 'String');
      if (data.hasOwnProperty('type'))
        obj.type = ApiClient.convertToType(data['type'], 'String');
    }
    return obj;
  }

  /**
   * @member {String} id
   */
  exports.prototype.id = undefined;

  /**
   * @member {String} name
   */
  exports.prototype.name = undefined;

  /**
   * @member {String} description
   */
  exports.prototype.description = undefined;

  /**
   * Business category
   * @member {String} category
   */
  exports.prototype.category = undefined;

  /**
   * labels or tags
   * @member {Array.<String>} tags
   */
  exports.prototype.tags = undefined;

  /**
   * @member {String} photoUrl
   */
  exports.prototype.photoUrl = undefined;

  /**
   * Internal business object type
   * @member {String} type
   */
  exports.prototype.type = undefined;

  return exports;

}));
