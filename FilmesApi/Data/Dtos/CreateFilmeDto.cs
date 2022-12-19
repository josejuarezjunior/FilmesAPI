﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O título do fime é obrigatório.")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do fime é obrigatório.")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres.")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "A duração do fime é obrigatória.")]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos.")]
    public int Duracao { get; set; }
}
