export interface Escuela {
  idEscuela: number;
  nombre: string;
  ubicacion: string;
  estado: string;
}

export interface Alumno {
  idAlumno: number;
  nombreA: string;
  apellido: string;
  correo: string;
  idEscuela: number;
  escuela?: Escuela;
}