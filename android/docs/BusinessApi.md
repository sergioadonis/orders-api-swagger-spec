# BusinessApi

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
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
BusinessProps businessProps = new BusinessProps(); // BusinessProps | 
try {
    Business result = apiInstance.createOneBusiness(businessProps);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#createOneBusiness");
    e.printStackTrace();
}
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

<a name="deleteOneBusiness"></a>
# **deleteOneBusiness**
> deleteOneBusiness(businessId)

Delete business

### Example
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
String businessId = "businessId_example"; // String | 
try {
    apiInstance.deleteOneBusiness(businessId);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#deleteOneBusiness");
    e.printStackTrace();
}
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
> List&lt;Business&gt; getBusinessesList()

Get businesses

### Example
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
try {
    List<Business> result = apiInstance.getBusinessesList();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#getBusinessesList");
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

<a name="getOneBusiness"></a>
# **getOneBusiness**
> Business getOneBusiness(businessId)

Get business

### Example
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
String businessId = "businessId_example"; // String | 
try {
    Business result = apiInstance.getOneBusiness(businessId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#getOneBusiness");
    e.printStackTrace();
}
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
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
String businessId = "businessId_example"; // String | 
BusinessProps businessProps = new BusinessProps(); // BusinessProps | 
try {
    Business result = apiInstance.updateOneBusiness(businessId, businessProps);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#updateOneBusiness");
    e.printStackTrace();
}
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

