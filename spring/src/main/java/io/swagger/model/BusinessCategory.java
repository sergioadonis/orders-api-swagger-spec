package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.model.BusinessCategoryStyle;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * Business category
 */
@ApiModel(description = "Business category")
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.languages.SpringCodegen", date = "2019-12-06T19:20:21.831Z")

public class BusinessCategory   {
  @JsonProperty("id")
  private Object id = null;

  @JsonProperty("name")
  private String name = null;

  @JsonProperty("description")
  private String description = null;

  @JsonProperty("style")
  private BusinessCategoryStyle style = null;

  public BusinessCategory id(Object id) {
    this.id = id;
    return this;
  }

  /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(value = "")


  public Object getId() {
    return id;
  }

  public void setId(Object id) {
    this.id = id;
  }

  public BusinessCategory name(String name) {
    this.name = name;
    return this;
  }

  /**
   * Get name
   * @return name
  **/
  @ApiModelProperty(example = "Mexican restaurant", value = "")


  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public BusinessCategory description(String description) {
    this.description = description;
    return this;
  }

  /**
   * Get description
   * @return description
  **/
  @ApiModelProperty(value = "")


  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public BusinessCategory style(BusinessCategoryStyle style) {
    this.style = style;
    return this;
  }

  /**
   * Get style
   * @return style
  **/
  @ApiModelProperty(value = "")

  @Valid

  public BusinessCategoryStyle getStyle() {
    return style;
  }

  public void setStyle(BusinessCategoryStyle style) {
    this.style = style;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BusinessCategory businessCategory = (BusinessCategory) o;
    return Objects.equals(this.id, businessCategory.id) &&
        Objects.equals(this.name, businessCategory.name) &&
        Objects.equals(this.description, businessCategory.description) &&
        Objects.equals(this.style, businessCategory.style);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, name, description, style);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BusinessCategory {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    style: ").append(toIndentedString(style)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

