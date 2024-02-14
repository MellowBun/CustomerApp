import { Component } from '@angular/core';
import { Customer } from '../customer';

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent {
  customers: Customer[] = [
    {
      customerID: 0,
      firstName: "Jesse",
      lastName: "Harlan",
      birthdate: new Date(),
      phoneNumbers: [],
      emails: [],
      addresses: []
    },
    {
      customerID: 1,
      firstName: "Sarah",
      lastName: "Harlan",
      birthdate: new Date(),
      phoneNumbers: [],
      emails: [],
      addresses: []
    }
  ];

}
