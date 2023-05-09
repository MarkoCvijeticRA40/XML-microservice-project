export class User {

    id : string = '';
    username: string = '';
    name: string = '';
    lastName: string = '';
    role: any = null;
    password: string = '';
    email: string = ''; 
    placeOfLiving: string = '';
 
    public constructor(obj?: any) {
        if (obj) {
            this.id = obj.id;
            this.username = obj.username;
            this.name = obj.name;
            this.lastName = obj.lastName;
            this.role = obj.role;
            this.password = obj.password;
            this.email = obj.email;
            this.placeOfLiving = obj.placeOfLiving;
        }
    }
}
