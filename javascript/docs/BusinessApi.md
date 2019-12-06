# OrdersApi.BusinessApi

All URIs are relative to *https://virtserver.swaggerhub.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createBusiness**](BusinessApi.md#createBusiness) | **POST** /business | Create business
[**deleteBusinessById**](BusinessApi.md#deleteBusinessById) | **DELETE** /business/{id} | Delete business by id
[**getBusinessById**](BusinessApi.md#getBusinessById) | **GET** /business/{id} | Get business by id
[**getBusinesses**](BusinessApi.md#getBusinesses) | **GET** /business | Get businesses
[**updateBusinessById**](BusinessApi.md#updateBusinessById) | **PUT** /business/{id} | Update business by id


<a name="createBusiness"></a>
# **createBusiness**
> Business createBusiness(bussines)

Create business

### Example
```javascript
import {OrdersApi} from 'orders_api';

let apiInstance = new OrdersApi.BusinessApi();

let bussines = new OrdersApi.Business(); // Business | 


apiInstance.createBusiness(bussines, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bussines** | [**Business**](Business.md)|  | 

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

Delete business by id

### Example
```javascript
import {OrdersApi} from 'orders_api';

let apiInstance = new OrdersApi.BusinessApi();

let id = "id_example"; // String | 


apiInstance.deleteBusinessById(id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
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

Get business by id

### Example
```javascript
import {OrdersApi} from 'orders_api';

let apiInstance = new OrdersApi.BusinessApi();

let id = "id_example"; // String | 


apiInstance.getBusinessById(id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
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
import {OrdersApi} from 'orders_api';

let apiInstance = new OrdersApi.BusinessApi();

apiInstance.getBusinesses((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
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
> Business updateBusinessById(id, bussines)

Update business by id

### Example
```javascript
import {OrdersApi} from 'orders_api';

let apiInstance = new OrdersApi.BusinessApi();

let id = "id_example"; // String | 

let bussines = new OrdersApi.Business(); // Business | 


apiInstance.updateBusinessById(id, bussines, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **bussines** | [**Business**](Business.md)|  | 

### Return type

[**Business**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

