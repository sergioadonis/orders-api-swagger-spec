'use strict';


/**
 * Create business
 *
 * bussines Business 
 * returns Business
 **/
exports.createBusiness = function(bussines) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "photoUrl" : "https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9",
  "name" : "El Zócalo",
  "description" : "Restaurante de comida mexicana, tequila, karaoke y mucho más!",
  "id" : "12ea34-651d76c-87bd-85b6f9",
  "category" : "Mexican restaurant",
  "type" : "RSTRNT",
  "tags" : [ "Mexican food", "Karaoke", "Tacos", "Tequila" ]
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Delete business by id
 *
 * id String 
 * no response value expected for this operation
 **/
exports.deleteBusinessById = function(id) {
  return new Promise(function(resolve, reject) {
    resolve();
  });
}


/**
 * Get business by id
 *
 * id String 
 * returns Business
 **/
exports.getBusinessById = function(id) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "photoUrl" : "https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9",
  "name" : "El Zócalo",
  "description" : "Restaurante de comida mexicana, tequila, karaoke y mucho más!",
  "id" : "12ea34-651d76c-87bd-85b6f9",
  "category" : "Mexican restaurant",
  "type" : "RSTRNT",
  "tags" : [ "Mexican food", "Karaoke", "Tacos", "Tequila" ]
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Get businesses
 *
 * returns List
 **/
exports.getBusinesses = function() {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = [ {
  "photoUrl" : "https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9",
  "name" : "El Zócalo",
  "description" : "Restaurante de comida mexicana, tequila, karaoke y mucho más!",
  "id" : "12ea34-651d76c-87bd-85b6f9",
  "category" : "Mexican restaurant",
  "type" : "RSTRNT",
  "tags" : [ "Mexican food", "Karaoke", "Tacos", "Tequila" ]
}, {
  "photoUrl" : "https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9",
  "name" : "El Zócalo",
  "description" : "Restaurante de comida mexicana, tequila, karaoke y mucho más!",
  "id" : "12ea34-651d76c-87bd-85b6f9",
  "category" : "Mexican restaurant",
  "type" : "RSTRNT",
  "tags" : [ "Mexican food", "Karaoke", "Tacos", "Tequila" ]
} ];
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Update business by id
 *
 * id String 
 * bussines Business 
 * returns Business
 **/
exports.updateBusinessById = function(id,bussines) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "photoUrl" : "https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9",
  "name" : "El Zócalo",
  "description" : "Restaurante de comida mexicana, tequila, karaoke y mucho más!",
  "id" : "12ea34-651d76c-87bd-85b6f9",
  "category" : "Mexican restaurant",
  "type" : "RSTRNT",
  "tags" : [ "Mexican food", "Karaoke", "Tacos", "Tequila" ]
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

