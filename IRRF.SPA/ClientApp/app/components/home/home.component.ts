import { Component } from '@angular/core';
import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/map';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {

    public vlrImposto = 0;  
    public vlrSalario = 0; 

    constructor(private http: Http) {
    }
    
    calcular() {
        this.http.get('http://localhost:5000/api/IRRF?salario='+ this.vlrSalario)
        .map((res:Response) => res.json())
        .subscribe(data => this.vlrImposto = data);
    }
}
