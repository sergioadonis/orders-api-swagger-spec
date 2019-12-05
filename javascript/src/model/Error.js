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

import {ApiClient} from '../ApiClient';

/**
 * The Error model module.
 * @module model/Error
 * @version 1.0.1
 */
export class Error {
  /**
   * Constructs a new <code>Error</code>.
   * @alias module:model/Error
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>Error</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Error} obj Optional instance to populate.
   * @return {module:model/Error} The populated <code>Error</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new Error();
      if (data.hasOwnProperty('code'))
        obj.code = ApiClient.convertToType(data['code'], 'String');
      if (data.hasOwnProperty('message'))
        obj.message = ApiClient.convertToType(data['message'], 'String');
      if (data.hasOwnProperty('target'))
        obj.target = ApiClient.convertToType(data['target'], 'String');
    }
    return obj;
  }
}

/**
 * @member {String} code
 */
Error.prototype.code = undefined;

/**
 * @member {String} message
 */
Error.prototype.message = undefined;

/**
 * @member {String} target
 */
Error.prototype.target = undefined;


