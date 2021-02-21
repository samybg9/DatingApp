import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Klendi\'s Dating app';
  users: any;
  kofa = 'dfdasdaas'

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getUsers()
  }

  getUsers(){
    this.http.get('https://localhost:44311/api/users').subscribe(response => {
      this.users = response
    }, error => {
      console.log(error)
    });
  }
}
