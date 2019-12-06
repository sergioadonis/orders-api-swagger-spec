'use strict';

var utils = require('../utils/writer.js');
var Business = require('../service/BusinessService');

module.exports.createBusiness = function createBusiness (req, res, next) {
  var bussines = req.swagger.params['bussines'].value;
  Business.createBusiness(bussines)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.deleteBusinessById = function deleteBusinessById (req, res, next) {
  var id = req.swagger.params['id'].value;
  Business.deleteBusinessById(id)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.getBusinessById = function getBusinessById (req, res, next) {
  var id = req.swagger.params['id'].value;
  Business.getBusinessById(id)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.getBusinesses = function getBusinesses (req, res, next) {
  Business.getBusinesses()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.updateBusinessById = function updateBusinessById (req, res, next) {
  var id = req.swagger.params['id'].value;
  var bussines = req.swagger.params['bussines'].value;
  Business.updateBusinessById(id,bussines)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
