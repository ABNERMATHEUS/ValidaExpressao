using System;

namespace ValidaExpressao
{
    public class ValidaExpressao
    {
        public bool valida(string expressao)
        {

            Pilha pilha = new Pilha(expressao.Length);
            var charVetor = expressao.ToCharArray();

            for(int i=0; i < expressao.Length; i++)
            {
                var posicao = charVetor[i];
                //ABERTO
                if (posicao is '(')
                    pilha.empilhar(posicao);
                
                else if(posicao is '~')
                    pilha.empilhar(posicao);
                
               /* else if(posicao is '→' && pilha.topo() is ')')
                    pilha.empilhar(charVetor[i]);*/
                


                if (pilha.vazia())
                    return false;
                
                else
                {
                    //FECHADO
                    if(posicao is ')' )
                    {
                        if (pilha.topo() is '(')
                            pilha.desempilhar();
                                             
                    }
                    else if (posicao.ToString().Contains('a'))
                    {
                        if (pilha.topo() is '~')
                            pilha.desempilhar();
                        
                    }/*
                    else if(posicao is '(')
                    {
                        
                        if (pilha.topo() is '→')
                            pilha.desempilhar();
                    }*/
                    
                }
            }

            return pilha.vazia();
        }

        public void ExpressoesParentes(string expresao)
        {

        }
    }
}
