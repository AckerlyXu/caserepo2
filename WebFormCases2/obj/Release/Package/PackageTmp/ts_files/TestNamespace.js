/// <reference  path="Validators.ts"/>
/// <reference  path="StringValidatorNamespace.ts"/>
/// <reference  path="ZipCodeValidatorNamespace.ts"/>
// Some samples to try
var strings = ["Hello", "98052", "101"];
// Validators to use
var validators = {};
validators["ZIP code"] = new Validation.ZipCodeValidator();
validators["Letters only"] = new Validation.LettersOnlyValidator();
// Show whether each string passed each validator
for (var _i = 0, strings_1 = strings; _i < strings_1.length; _i++) {
    var s = strings_1[_i];
    for (var name_1 in validators) {
        var isMatch = validators[name_1].isAcceptable(s);
        console.log("'" + s + "' " + (isMatch ? "matches" : "does not match") + " '" + name_1 + "'.");
    }
}
//# sourceMappingURL=TestNamespace.js.map