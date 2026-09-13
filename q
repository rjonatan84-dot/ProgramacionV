[1mdiff --git a/Models/Estudiante.cs b/Models/Estudiante.cs[m
[1mindex 429a919..8c5ad08 100644[m
[1m--- a/Models/Estudiante.cs[m
[1m+++ b/Models/Estudiante.cs[m
[36m@@ -11,6 +11,8 @@[m [mpublic class Estudiante[m
   public string Correo { get; set; } = string.Empty;[m
  [m
   public int ProgramaAcademicoId { get; set; }[m
[32m+[m
[32m+[m[32m  public string? Telefono { get; set; }[m
  [m
   public ProgramaAcademico? ProgramaAcademico { get; set; }[m
 }[m
\ No newline at end of file[m
