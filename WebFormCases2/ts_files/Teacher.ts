

class Teacher {
    constructor(public subject: string, public age: number) {

    }
}

export = Teacher;


class A {
    id: number;
    name:string
}
class B {
   
    constructor(public id: number, public name: string,public hobby:string) {

    }
}
let m: A = new A();
let b: B = new B(1,"abc","string");
m=b;
