/**
 * Orders API
 * Simple API to manage businesses and orders
 *
 * OpenAPI spec version: 1.0.1
 * Contact: sergio.adonis@outlook.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import io.swagger.client.model.BusinessProps;
import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;

@ApiModel(description = "")
public class Business {
  
  @SerializedName("id")
  private String id = null;
  @SerializedName("props")
  private BusinessProps props = null;

  /**
   **/
  @ApiModelProperty(value = "")
  public String getId() {
    return id;
  }
  public void setId(String id) {
    this.id = id;
  }

  /**
   **/
  @ApiModelProperty(value = "")
  public BusinessProps getProps() {
    return props;
  }
  public void setProps(BusinessProps props) {
    this.props = props;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Business business = (Business) o;
    return (this.id == null ? business.id == null : this.id.equals(business.id)) &&
        (this.props == null ? business.props == null : this.props.equals(business.props));
  }

  @Override
  public int hashCode() {
    int result = 17;
    result = 31 * result + (this.id == null ? 0: this.id.hashCode());
    result = 31 * result + (this.props == null ? 0: this.props.hashCode());
    return result;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Business {\n");
    
    sb.append("  id: ").append(id).append("\n");
    sb.append("  props: ").append(props).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
