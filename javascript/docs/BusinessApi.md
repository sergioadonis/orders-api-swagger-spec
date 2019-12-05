# OrdersApi.BusinessApi

All URIs are relative to *https://virtserver.swaggerhub.com/sergioadonis/orders-api/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createBusiness**](BusinessApi.md#createBusiness) | **POST** /business | Create business
[**deleteBusinessById**](BusinessApi.md#deleteBusinessById) | **DELETE** /business/{id} | Delete business
[**getBusinessById**](BusinessApi.md#getBusinessById) | **GET** /business/{id} | Get business
[**getBusinesses**](BusinessApi.md#getBusinesses) | **GET** /business | Get businesses
[**updateBusinessById**](BusinessApi.md#updateBusinessById) | **PUT** /business/{id} | Update business


<a name="createBusiness"></a>
# **createBusiness**
> Business createBusiness(props)

Create business

### Example
```javascript
var OrdersApi = require('orders_api');

var apiInstance = new OrdersApi.BusinessApi();

var props = new OrdersApi.Props(); // Props | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.createBusiness(props, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **props** | [**Props**](Props.md)|  | 

### Return type

[**Business**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deleteBusinessById"></a>
# **deleteBusinessById**
> deleteBusinessById(id)

Delete business

### Example
```javascript
var OrdersApi = require('orders_api');

var apiInstance = new OrdersApi.BusinessApi();

var id = "id_example"; // String | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deleteBusinessById(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getBusinessById"></a>
# **getBusinessById**
> Business getBusinessById(id)

Get business

### Example
```javascript
var OrdersApi = require('orders_api');

var apiInstance = new OrdersApi.BusinessApi();

var id = "id_example"; // String | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getBusinessById(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Business**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getBusinesses"></a>
# **getBusinesses**
> [Business] getBusinesses()

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
apiInstance.getBusinesses(callback);
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

<a name="updateBusinessById"></a>
# **updateBusinessById**
> Business updateBusinessById(id, props)

Update business

### Example
```javascript
var OrdersApi = require('orders_api');

var apiInstance = new OrdersApi.BusinessApi();

var id = "id_example"; // String | 

var props = new OrdersApi.Props(); // Props | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.updateBusinessById(id, props, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **props** | [**Props**](Props.md)|  | 

### Return type

[**Business**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

