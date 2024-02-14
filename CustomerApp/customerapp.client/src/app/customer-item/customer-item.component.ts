import { Component, Input } from '@angular/core';
import { Customer } from '../customer';

@Component({
  selector: 'app-customer-item',
  templateUrl: './customer-item.component.html',
  styleUrls: ['./customer-item.component.css']
})
export class CustomerItemComponent {
  @Input() customer: Customer = {
    customerID: 0,
    firstName: "Test",
    lastName: "User",
    birthdate: new Date(),
    phoneNumbers: [],
    emails: [],
    addresses: []
  };
}
