# OrdersApi.BusinessApi

All URIs are relative to *https://virtserver.swaggerhub.com/sergioadonis/orders-api/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createOneBusiness**](BusinessApi.md#createOneBusiness) | **POST** /business | Create business
[**deleteOneBusiness**](BusinessApi.md#deleteOneBusiness) | **DELETE** /business/{businessId} | Delete business
[**getBusinessesList**](BusinessApi.md#getBusinessesList) | **GET** /business | Get businesses
[**getOneBusiness**](BusinessApi.md#getOneBusiness) | **GET** /business/{businessId} | Get business
[**updateOneBusiness**](BusinessApi.md#updateOneBusiness) | **PUT** /business/{businessId} | Update business


<a name="createOneBusiness"></a>
# **createOneBusiness**
> Business createOneBusiness(businessProps)

Create business

### Example
```javascript
var OrdersApi = require('orders_api');

var apiInstance = new OrdersApi.BusinessApi();

var businessProps = new OrdersApi.Props(); // Props | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.createOneBusiness(businessProps, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessProps** | [**Props**](Props.md)|  | 

### Return type

[**Business**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deleteOneBusiness"></a>
# **deleteOneBusiness**
> deleteOneBusiness(businessId)

Delete business

### Example
```javascript
var OrdersApi = require('orders_api');

var apiInstance = new OrdersApi.BusinessApi();

var businessId = "businessId_example"; // String | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deleteOneBusiness(businessId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessId** | **String**|  | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getBusinessesList"></a>
# **getBusinessesList**
> [Business] getBusinessesList()

Get businesses

### Example
```javascript
var OrdersApi = require('orders_api');

var apiInstance = new OrdersApi.BusinessApi();

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getBusinessesList(callback);
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**[Business]**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getOneBusiness"></a>
# **getOneBusiness**
> Business getOneBusiness(businessId)

Get business

### Example
```javascript
var OrdersApi = require('orders_api');

var apiInstance = new OrdersApi.BusinessApi();

var businessId = "businessId_example"; // String | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getOneBusiness(businessId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessId** | **String**|  | 

### Return type

[**Business**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateOneBusiness"></a>
# **updateOneBusiness**
> Business updateOneBusiness(businessId, businessProps)

Update business

### Example
```javascript
var OrdersApi = require('orders_api');

var apiInstance = new OrdersApi.BusinessApi();

var businessId = "businessId_example"; // String | 

var businessProps = new OrdersApi.Props(); // Props | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.updateOneBusiness(businessId, businessProps, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessId** | **String**|  | 
 **businessProps** | [**Props**](Props.md)|  | 

### Return type

[**Business**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

