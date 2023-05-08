export class LoginData {
    
    id : string = '';
    username: string = '';
    name: string = '';
    lastname: string = '';
    role: any = null;
    placeOfLiving: string = '';



    Email: string = '';
    Password: string = '';

    public constructor(obj?: any) {
        if (obj) {
            this.Email = obj.Email;
            this.Password = obj.Password;
            this.id = obj.id;
            this.username = obj.username;
            this.name = obj.name;
            this.lastname= obj.lastname;
            this.role = obj.role;
            this.placeOfLiving = obj.placeOfLiving;
        }
    }
}