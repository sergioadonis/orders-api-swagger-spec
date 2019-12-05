# BusinessApi

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
> Business createBusiness(bussinesProps)

Create business

### Example
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
Props bussinesProps = new Props(); // Props | 
try {
    Business result = apiInstance.createBusiness(bussinesProps);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#createBusiness");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bussinesProps** | [**Props**](Props.md)|  |

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
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
String id = "id_example"; // String | 
try {
    apiInstance.deleteBusinessById(id);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#deleteBusinessById");
    e.printStackTrace();
}
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
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
String id = "id_example"; // String | 
try {
    Business result = apiInstance.getBusinessById(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#getBusinessById");
    e.printStackTrace();
}
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
> List&lt;Business&gt; getBusinesses()

Get businesses

### Example
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
try {
    List<Business> result = apiInstance.getBusinesses();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#getBusinesses");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Business&gt;**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateBusinessById"></a>
# **updateBusinessById**
> Business updateBusinessById(id, bussinesProps)

Update business

### Example
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
String id = "id_example"; // String | 
Props bussinesProps = new Props(); // Props | 
try {
    Business result = apiInstance.updateBusinessById(id, bussinesProps);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#updateBusinessById");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  |
 **bussinesProps** | [**Props**](Props.md)|  |

### Return type

[**Business**](Business.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

