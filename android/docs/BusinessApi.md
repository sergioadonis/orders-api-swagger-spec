# BusinessApi

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
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
String businessId = "businessId_example"; // String | 
try {
    apiInstance.businessBusinessIdDelete(businessId);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#businessBusinessIdDelete");
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

<a name="businessBusinessIdGet"></a>
# **businessBusinessIdGet**
> Business businessBusinessIdGet(businessId)

Get business

### Example
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
String businessId = "businessId_example"; // String | 
try {
    Business result = apiInstance.businessBusinessIdGet(businessId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#businessBusinessIdGet");
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

<a name="businessBusinessIdPut"></a>
# **businessBusinessIdPut**
> Business businessBusinessIdPut(businessId, businessProps)

Update business

### Example
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
String businessId = "businessId_example"; // String | 
BusinessProps businessProps = new BusinessProps(); // BusinessProps | 
try {
    Business result = apiInstance.businessBusinessIdPut(businessId, businessProps);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#businessBusinessIdPut");
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

<a name="businessGet"></a>
# **businessGet**
> List&lt;Business&gt; businessGet()

Get businesses

### Example
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
try {
    List<Business> result = apiInstance.businessGet();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#businessGet");
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

<a name="businessPost"></a>
# **businessPost**
> Business businessPost(businessProps)

Create business

### Example
```java
// Import classes:
//import io.swagger.client.api.BusinessApi;

BusinessApi apiInstance = new BusinessApi();
BusinessProps businessProps = new BusinessProps(); // BusinessProps | 
try {
    Business result = apiInstance.businessPost(businessProps);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling BusinessApi#businessPost");
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

