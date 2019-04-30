"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var StringValidator_1 = require("./StringValidator");
exports.numberRegexp = /^[0-9]+$/;
var ZipCodeValidator = /** @class */ (function () {
    function ZipCodeValidator() {
    }
    ZipCodeValidator.prototype.isAcceptable = function (s) {
        return true;
    };
    return ZipCodeValidator;
}());
exports.NewCodeValidator = ZipCodeValidator;
var stu = new StringValidator_1.default("ackerly", 25);
var Tea = require("./Teacher");
var teacher = new Tea("maths", 18);
//# sourceMappingURL=ZipCodeValidator.js.map