package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.model.BusinessCategory;
import io.swagger.model.BusinessGeoLocation;
import java.util.ArrayList;
import java.util.List;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * Business
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.languages.SpringCodegen", date = "2019-12-06T19:18:23.260Z")

public class Business   {
  @JsonProperty("id")
  private String id = null;

  @JsonProperty("name")
  private String name = null;

  @JsonProperty("description")
  private String description = null;

  @JsonProperty("category")
  private BusinessCategory category = null;

  @JsonProperty("phoneNumber")
  private String phoneNumber = null;

  @JsonProperty("address")
  private String address = null;

  @JsonProperty("geoLocation")
  private BusinessGeoLocation geoLocation = null;

  @JsonProperty("tags")
  @Valid
  private List<String> tags = null;

  @JsonProperty("photoUrl")
  private String photoUrl = null;

  @JsonProperty("type")
  private String type = null;

  public Business id(String id) {
    this.id = id;
    return this;
  }

  /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(example = "12ea34-651d76c-87bd-85b6f9", value = "")


  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }

  public Business name(String name) {
    this.name = name;
    return this;
  }

  /**
   * Get name
   * @return name
  **/
  @ApiModelProperty(example = "El Zócalo", required = true, value = "")
  @NotNull


  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public Business description(String description) {
    this.description = description;
    return this;
  }

  /**
   * Get description
   * @return description
  **/
  @ApiModelProperty(example = "Restaurante de comida mexicana, tequila, karaoke y mucho más!", value = "")


  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public Business category(BusinessCategory category) {
    this.category = category;
    return this;
  }

  /**
   * Get category
   * @return category
  **/
  @ApiModelProperty(value = "")

  @Valid

  public BusinessCategory getCategory() {
    return category;
  }

  public void setCategory(BusinessCategory category) {
    this.category = category;
  }

  public Business phoneNumber(String phoneNumber) {
    this.phoneNumber = phoneNumber;
    return this;
  }

  /**
   * Get phoneNumber
   * @return phoneNumber
  **/
  @ApiModelProperty(example = "2222-5555", value = "")


  public String getPhoneNumber() {
    return phoneNumber;
  }

  public void setPhoneNumber(String phoneNumber) {
    this.phoneNumber = phoneNumber;
  }

  public Business address(String address) {
    this.address = address;
    return this;
  }

  /**
   * Get address
   * @return address
  **/
  @ApiModelProperty(example = "La direccion del negocio", value = "")


  public String getAddress() {
    return address;
  }

  public void setAddress(String address) {
    this.address = address;
  }

  public Business geoLocation(BusinessGeoLocation geoLocation) {
    this.geoLocation = geoLocation;
    return this;
  }

  /**
   * Get geoLocation
   * @return geoLocation
  **/
  @ApiModelProperty(value = "")

  @Valid

  public BusinessGeoLocation getGeoLocation() {
    return geoLocation;
  }

  public void setGeoLocation(BusinessGeoLocation geoLocation) {
    this.geoLocation = geoLocation;
  }

  public Business tags(List<String> tags) {
    this.tags = tags;
    return this;
  }

  public Business addTagsItem(String tagsItem) {
    if (this.tags == null) {
      this.tags = new ArrayList<String>();
    }
    this.tags.add(tagsItem);
    return this;
  }

  /**
   * labels or tags
   * @return tags
  **/
  @ApiModelProperty(example = "[\"Mexican food\",\"Karaoke\",\"Tacos\",\"Tequila\"]", value = "labels or tags")


  public List<String> getTags() {
    return tags;
  }

  public void setTags(List<String> tags) {
    this.tags = tags;
  }

  public Business photoUrl(String photoUrl) {
    this.photoUrl = photoUrl;
    return this;
  }

  /**
   * Get photoUrl
   * @return photoUrl
  **/
  @ApiModelProperty(example = "https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9", value = "")


  public String getPhotoUrl() {
    return photoUrl;
  }

  public void setPhotoUrl(String photoUrl) {
    this.photoUrl = photoUrl;
  }

  public Business type(String type) {
    this.type = type;
    return this;
  }

  /**
   * Internal business object type
   * @return type
  **/
  @ApiModelProperty(example = "RSTRNT", value = "Internal business object type")


  public String getType() {
    return type;
  }

  public void setType(String type) {
    this.type = type;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Business business = (Business) o;
    return Objects.equals(this.id, business.id) &&
        Objects.equals(this.name, business.name) &&
        Objects.equals(this.description, business.description) &&
        Objects.equals(this.category, business.category) &&
        Objects.equals(this.phoneNumber, business.phoneNumber) &&
        Objects.equals(this.address, business.address) &&
        Objects.equals(this.geoLocation, business.geoLocation) &&
        Objects.equals(this.tags, business.tags) &&
        Objects.equals(this.photoUrl, business.photoUrl) &&
        Objects.equals(this.type, business.type);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, name, description, category, phoneNumber, address, geoLocation, tags, photoUrl, type);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Business {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    category: ").append(toIndentedString(category)).append("\n");
    sb.append("    phoneNumber: ").append(toIndentedString(phoneNumber)).append("\n");
    sb.append("    address: ").append(toIndentedString(address)).append("\n");
    sb.append("    geoLocation: ").append(toIndentedString(geoLocation)).append("\n");
    sb.append("    tags: ").append(toIndentedString(tags)).append("\n");
    sb.append("    photoUrl: ").append(toIndentedString(photoUrl)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
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

