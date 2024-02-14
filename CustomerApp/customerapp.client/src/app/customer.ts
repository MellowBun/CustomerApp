// model for a customer in typscript
export interface Customer {
  customerID: number;
  firstName: string;
  lastName: string;
  birthdate: Date;
  phoneNumbers: any[];
  emails: any[];
  addresses: any[];
}
