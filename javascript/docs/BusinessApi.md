# OrdersApi.BusinessApi

All URIs are relative to *https://virtserver.swaggerhub.com/sergioadonis/orders-api/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**businessBusinessIdDelete**](BusinessApi.md#businessBusinessIdDelete) | **DELETE** /business/{businessId} | Delete business
[**businessBusinessIdGet**](BusinessApi.md#businessBusinessIdGet) | **GET** /business/{businessId} | Get business
[**businessBusinessIdPut**](BusinessApi.md#businessBusinessIdPut) | **PUT** /business/{businessId} | Update business
[**businessGet**](BusinessApi.md#businessGet) | **GET** /business | Get businesses
[**businessPost**](BusinessApi.md#businessPost) | **POST** /business | Create business


<a name="businessBusinessIdDelete"></a>
# **businessBusinessIdDelete**
> businessBusinessIdDelete(businessId)

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
apiInstance.businessBusinessIdDelete(businessId, callback);
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

<a name="businessBusinessIdGet"></a>
# **businessBusinessIdGet**
> Business businessBusinessIdGet(businessId)

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
apiInstance.businessBusinessIdGet(businessId, callback);
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

<a name="businessBusinessIdPut"></a>
# **businessBusinessIdPut**
> Business businessBusinessIdPut(businessId, businessProps)

Update business

### Example
```javascript
var OrdersApi = require('orders_api');

var apiInstance = new OrdersApi.BusinessApi();

var businessId = "businessId_example"; // String | 

var businessProps = new OrdersApi.BusinessProps(); // BusinessProps | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.businessBusinessIdPut(businessId, businessProps, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessId** | **String**|  | 
 **businessProps** | [**BusinessProps**](BusinessProps.md)|  | 

### Return type

[**Business**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="businessGet"></a>
# **businessGet**
> [Business] businessGet()

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
apiInstance.businessGet(callback);
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

<a name="businessPost"></a>
# **businessPost**
> Business businessPost(businessProps)

Create business

### Example
```javascript
var OrdersApi = require('orders_api');

var apiInstance = new OrdersApi.BusinessApi();

var businessProps = new OrdersApi.BusinessProps(); // BusinessProps | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.businessPost(businessProps, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessProps** | [**BusinessProps**](BusinessProps.md)|  | 

### Return type

[**Business**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

