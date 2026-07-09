namespace POO.ClassesEOutrosTipos.Record;

// public record Curso
// {
//     public int Id { get; set; }
//     public string Descricao { get; set; }

    // public override bool Equals(object obj)
    // {
    //     if (obj == null)
    //     {
    //         return false;
    //     }
    //
    //     if (obj is Curso curso)
    //     {
    //         var validacao = Id == curso.Id && Descricao == curso.Descricao;
    //         return validacao;
    //     }
    //
    //     return false;
    // }
    //
    // public static bool operator ==(Curso a, Curso b)
    // {
    //     return a.Equals(b);
    // }
    //
    // public static bool operator !=(Curso a, Curso b)
    // {
    //     return !(a.Equals(b));
    // }
// };

public record Curso(int Id, string Descricao);