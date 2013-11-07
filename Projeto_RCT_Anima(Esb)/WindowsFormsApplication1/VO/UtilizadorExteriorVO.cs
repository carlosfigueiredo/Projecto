using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.VO
{
    public class UtilizadorExteriorVO
    {
    private int _idUtilizador;
    private int _idConcelho;
    private string _nomeConcelho;
    private string _nomeDistrito;
    private string _nome;
    private string _email;
    private string _telefone;
    private string _marcaExploracao;
    private string _username;
    private string _password;
    private string _morada;
    private string _codigoPostal;
    private DateTime _dataRegisto;
    private int _numeroCabecas;
    private string _racaPredominante;
    private bool _ativo;
    private int _contaControlo;
    private DateTime _ultimaDataControlo;
    private DateTime _dataExpira;


    public int idUtilizador
    {
        get
        {
            return _idUtilizador;
        }

        set
        {
            _idUtilizador = value;
        }
    }

    public int idConcelho
    {
        get
        {
            return _idConcelho;
        }

        set
        {
            _idConcelho = value;
        }
    }

    public string nomeConcelho
    {
        get
        {
            return _nomeConcelho;
        }

        set
        {
            _nomeConcelho = value;
        }
    }

    public string nomeDistrito
    {
        get
        {
            return _nomeDistrito;
        }

        set
        {
            _nomeDistrito = value;
        }
    }

    public string nome
    {
        get
        {
            return _nome;
        }

        set
        {
            _nome = value;
        }
    }

    public string email
    {
        get
        {
            return _email;
        }

        set
        {
            _email = value;
        }
    }

    public string telefone
    {
        get
        {
            return _telefone;
        }

        set
        {
            _telefone = value;
        }
    }

    public string marcaExploracao
    {
        get
        {
            return _marcaExploracao;
        }

        set
        {
            _marcaExploracao = value;
        }
    }

    public string username
    {
        get
        {
            return _username;
        }

        set
        {
            _username = value;
        }
    }

    public string password
    {
        get
        {
            return _password;
        }

        set
        {
            _password = value;
        }
    }

    public string morada
    {
        get
        {
            return _morada;
        }

        set
        {
            _morada = value;
        }
    }

    public string codigoPostal
    {
        get
        {
            return _codigoPostal;
        }

        set
        {
            _codigoPostal = value;
        }
    }

    public DateTime dataRegisto
    {
        get
        {
            return _dataRegisto;
        }

        set
        {
            _dataRegisto = value;
        }
    }

    public int numeroCabecas
    {
        get
        {
            return _numeroCabecas;
        }

        set
        {
            _numeroCabecas = value;
        }
    }


    public string RacaPredominante
    {
        get { return _racaPredominante; }
        set { _racaPredominante = value; }
    }

    public bool ativo
    {
        get
        {
            return _ativo;
        }

        set
        {
            _ativo = value;
        }
    }

    public int contaControlo
    {
        get
        {
            return _contaControlo;
        }

        set
        {
            _contaControlo = value;
        }
    }

    public DateTime ultimaDataControlo
    {
        get
        {
            return _ultimaDataControlo;
        }

        set
        {
            _ultimaDataControlo = value;
        }
    }

    public DateTime dataExpira
    {
        get
        {
            return _dataExpira; 
        }
        set 
        {
            _dataExpira = value; 
        }
    }




    }
}
