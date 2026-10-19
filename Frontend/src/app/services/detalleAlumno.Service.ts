import {Injectable ,inject} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Alumno} from '../models/documentoAlumno';

@Injectable({providedIn:'root'})
export class AlumnoService{
    private http=inject(HttpClient);
    private api='https://localhost:7164/api/BackAlumno';

    listar(){
        return this.http.get<Alumno[]>(`${this.api}/listar`);

    }

    details(id:number){
       return this.http.get<Alumno>(`${this.api}/details/${id}`);
 
    }
}