"use strict";
var Teacher = /** @class */ (function () {
    function Teacher(subject, age) {
        this.subject = subject;
        this.age = age;
    }
    return Teacher;
}());
var A = /** @class */ (function () {
    function A() {
    }
    return A;
}());
var B = /** @class */ (function () {
    function B(id, name, hobby) {
        this.id = id;
        this.name = name;
        this.hobby = hobby;
    }
    return B;
}());
var m = new A();
var b = new B(1, "abc", "string");
m = b;
module.exports = Teacher;
//# sourceMappingURL=Teacher.js.map