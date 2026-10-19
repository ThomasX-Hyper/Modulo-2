import {Component , inject,signal} from '@angular/core';
import {DatePipe} from '@angular/common'; 
import {Router} from '@angular/router'; 
import {Alumno} from '../models/documentoAlumno';
import {AlumnoService} from '../services/detalleAlumno.Service';  


@Component({
    selector:'app-panel-detalle',
    standalone:true,
    imports:[DatePipe],
    templateUrl:'./detalleAlumnoPanel.html',
    styleUrl:'./detalleAlumnoPanel.css'
})
export class DetalleAlumnoPanel{
    private servicio=inject(AlumnoService);
    private router=inject(Router);

    mini=false;
    abierto=true;
    usuario = 'Ramos';
    inicial = this.usuario.charAt(0).toUpperCase();

     lista = signal<Alumno[]>([]);
    estado:'inicio'|'cargando'|'ok'|'error'='inicio';
    error = signal(false);

     constructor() {
    this.servicio.listar().subscribe({
      next: datos => this.lista.set(datos),
      error: err => {
        console.error('Error:', err);
        this.error.set(true);
      }
    });
  }

    
    ver(id:number){
        this.router.navigate(['details',id]);
    }
}