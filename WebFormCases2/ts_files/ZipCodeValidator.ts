import { StringValidator } from "./StringValidator";
import  Stu from "./StringValidator";

export const numberRegexp = /^[0-9]+$/;
 class ZipCodeValidator implements StringValidator {
    isAcceptable(s: string): boolean {
        return true;
    }
}
let stu = new Stu("ackerly", 25);
export { ZipCodeValidator as NewCodeValidator };
export { StringValidator as RegBasedZip } from "./StringValidator";


import Tea = require("./Teacher");
let teacher = new Tea("maths", 18);

