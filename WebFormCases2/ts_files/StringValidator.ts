export interface StringValidator {
    isAcceptable(s: string): boolean;
};

export default class Student{
    constructor(public name:string,public age:number){

    }
}

let mydefault: number = 6;

