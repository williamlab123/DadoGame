#include<stdio.h>
#include<time.h>
#include<stdlib.h>
#include <unistd.h>
#define DINHEIRO_INICAL 1000


  



void Dado1()
{
                     
                                           //DADO VALOR 1
//*****************************************************************************************************
 
  
  
   

    for(int i=0;i<11;i++)
      {

        printf("_");

      }

     printf("\n");


   
    printf("|           |\n");
     
    printf("|           |\n");
     
    printf("|     *     |\n");

    printf("|           |\n");
     

       printf("|");
      

      for(int i=0;i<11;i++)
      {

        printf("_");

      }

       printf("|");
        printf("\n"); 
}



void Dado2()
{
                                                //DADO VALOR 2  
  // ***************************************************************************************************
    printf(" ");
  


    for(int i=0;i<11;i++)
      {        

        printf("_");

      }

     printf("\n");


   
    printf("|           |\n");
     
    printf("|  *        |\n");
     
    printf("|           |\n");

    printf("|        *  |\n");
    

       printf("|");
      

      for(int i=0;i<11;i++)
      {

        printf("_");

      }

       printf("|");
        printf("\n");

}


void Dado3()
{
                                                    //DADO VALOR 3  
  // ***************************************************************************************************
    printf(" ");
  


    for(int i=0;i<11;i++)
      {

        printf("_");

      }

     printf("\n");


   
    
     
    printf("|           |\n");
     
    printf("|        *  |\n");

    printf("|     *     |\n");

    printf("|  *        |\n");
      
    

       printf("|");
      

      for(int i=0;i<11;i++)
      {

        printf("_");

      }

       printf("|");
        printf("\n");

}

void Dado4()
{

                                                     //DADO VALOR 4  
  // ***************************************************************************************************
    printf(" ");
  


    for(int i=0;i<11;i++)
      {

        printf("_");

      }

     printf("\n");


   
    
     
    printf("|           |\n");
     
    printf("|  *     *  |\n");

    printf("|           |\n");

    printf("|  *     *  |\n");
      
    

       printf("|");
      

      for(int i=0;i<11;i++)
      {

        printf("_");

      }

       printf("|");
        printf("\n");

}

void Dado5()
{

                                                     //DADO VALOR 5  
  // ***************************************************************************************************
    printf(" ");
  


    for(int i=0;i<11;i++)
      {

        printf("_");

      }

     printf("\n");


   
    
     
    printf("|           |\n");
     
    printf("|  *     *  |\n");

    printf("|     *     |\n");

    printf("|  *     *  |\n");
      
    

       printf("|");
      

      for(int i=0;i<11;i++)
      {

        printf("_");

      }

       printf("|");
        printf("\n");


}

void Dado6()
{
                                                     //DADO VALOR 6 
  // ***************************************************************************************************
    printf(" ");
  


    for(int i=0;i<11;i++)
      {

        printf("_");

      }

     printf("\n");


   
    
     
    printf("|           |\n");
      
    printf("|  *     *  |\n");

    printf("|  *     *  |\n");

    printf("|  *     *  |\n");
      
    

       printf("|");
      

      for(int i=0;i<11;i++)
      {

        printf("_");

      }

       printf("|");
        printf("\n");


}



int SomatoriaRandom;

//gera os numeros aleatorios pro pc
int Randons()
{
   int random;
    int random1;
     int random2;
    

       srand(time(NULL));
      
         
              random =  rand() % 6;
               random1 =  rand() % 6; 
                random2 =  rand() % 6;


            SomatoriaRandom = random + random1 + random2;

            

            
 

           switch(SomatoriaRandom)
           {

            
           case 0:
              printf("\nTente na próxima. Voce acaba de perder metade das suas moedas.\n"); 
             break;  
           case 12:
             printf("\nQUE SORTE. Voce acaba de ganhar o dobro do dinheiro apostado.\n");
             break;

           case 3:
             printf("\nQUE AZAR. Voce acaba de pagar o dobro do dinheiro apostado.\n");
             break;

            case 15:
               printf("\nPARABENS, voce acaba de fazer uma trinca.\n");

           
            default:
              printf(" ");
              break;
           }          

        
      

      printf("\n");

      
     //o pc "escolhe" os numeros pra jogar
     switch(random)
     {
       case 0:
         //printf("o computador escolheu 1\n");
          Dado1();
         break;


       case 1:
       //  printf("o computador escolheu 2\n");
          Dado2();
           
         break;

       case 2:
       // printf("o pc escolheu 3\n");
          Dado3();
         break;

         case 3:
        // printf("o pc escolheu 4\n");
          Dado4();
         break;

        case 4:
        // printf("o pc escolheu 5\n");
          Dado5();
         break;

        case 5:
        // printf("o pc escolheu 6\n");
          Dado6();
         break;
           
    
       default:

        printf("%i o computador nao conseguiu escolher, por favor reinicie o jogo", random);
          break;
     }

//************************************************************************************************
      switch(random1)
      {
        case 0:
         // printf("o computador escolheu 1\n");
            Dado1();
          break;


        case 1:
        // printf("o computador escolheu 2\n");
            Dado2();
            
          break;

        case 2:
         // printf("o pc escolheu 3\n");
            Dado3();
          break;

          case 3:
         // printf("o pc escolheu 4\n");
            Dado4();
          break;

        case 4:
         // printf("o pc escolheu 5\n");
            Dado5();
          break;

          case 5:
         // printf("o pc escolheu 6\n");
            Dado6();
          break;
            
      
        default:

          printf("%i o computador nao conseguiu escolher, por favor reinicie o jogo", random);
            break;

      }

     //*************************************************************************************************

     switch(random2)
     {
     case 0:
        // printf("o computador escolheu 1\n");
          Dado1();
         break;


       case 1:
        // printf("o computador escolheu 2\n");
          Dado2();
           
         break;

      case 2:
        // printf("o pc escolheu 3\n");
          Dado3();
         break;

         case 3:
        // printf("o pc escolheu 4\n");
          Dado4();
         break;

       case 4:
        // printf("o pc escolheu 5\n");
          Dado5();
         break;

        case 5:
        // printf("o pc escolheu 6\n");
          Dado6();
         break;
           
    
      default:

        printf("%i o computador nao conseguiu escolher, por favor reinicie o jogo", random);
             break;

     }
//************************************************************************************************************

  

 //********************************************************************************************************
 
  

}



 //**********************************************************************************************************


 int Dinheiro_Pc;
 
//calcula, salva  e escolhe a quantidade de dinheiro que o pc tem e aposta 
int DinheiroPc()
{
  int QntDinheiroPc = DINHEIRO_INICAL;
   int apostaPc[4] = {50,100,150,200};
    int indice;

  
  srand(time(NULL));

    indice = rand() % (0-4); 



    

    printf("\nO computador apostou: %i\n\n", apostaPc[indice]);

    QntDinheiroPc = QntDinheiroPc - apostaPc[indice];


   
    Dinheiro_Pc = QntDinheiroPc;
     return Dinheiro_Pc;

    

    


}



int Dinheiro_Player;

//salva e calcula a quantidade de dinheiro que o jogador tem
int DinheiroPlayer(int QntDinheiroPlayer)
{
 QntDinheiroPlayer = DINHEIRO_INICAL;
   printf("Voce tem: %i", QntDinheiroPlayer);
    printf(" moedas.\n");
     printf("Quanto você deseja apostar?\n");
      int aposta;
       scanf("%i", &aposta);

       
     
    if(aposta < 50)
    {
      printf("Apostas com valores menores que 50 não são permitidas.\n");
       DinheiroPlayer(QntDinheiroPlayer);
      
    }

    else if(aposta > QntDinheiroPlayer)
    {
      printf("Você está apostando mais do que tem. Infelizmente empréstimos não são disponíveis ):\n");
       DinheiroPlayer(QntDinheiroPlayer);
    }

    QntDinheiroPlayer = QntDinheiroPlayer - aposta;
     return QntDinheiroPlayer;

    

    

    
     
}


//printa as regras
void Regras()
{
   
    printf("\nO jogo começa no turno 0. O turno 0 é usado pra começar as apostas.\n");
    printf("Voce começa com 1000(mil) moedas.\n");
    printf("A cada turno voce tem que apostar pelo menos 50 moedas.\n");
    printf("Voce joga 3 dados por vez.\n");
    printf("Se a combinaçao dos for: 1-2-3{AZAR}, voce paga o dobro.\n");
    printf("As trincas dobram o valor atual das sua moedas.\n");
    printf("Se a combinaçao for: 4-5-6{SORTE}, voce ganha o dobro.\n");
    printf("O jogo nao tem limite de turno ou seja, começa no turno 0 e so termina quando alguem perder.\n");
    printf("Voce perde quando fica sem dinheiro pra apostar.\n");
    printf("Se der empate, o dinheiro apostado volta.\n");
    printf("Depois que as apostas sao feitas, voce pode jogar o dado. Se quiser refazer as apostas digite 2\n\n");
    
}

int testo = 10;

 void PassarTurno()
 {
   
    DinheiroPc();
    DinheiroPlayer(testo);
 }



//troca os turnos, inicia os jogos.
void Turno()
{


  int turno = 0;
    turno++;

   printf("Apostas feitas, jogue os dados[1]");
    int JogarDado;
     scanf("%i", &JogarDado); 
      switch (JogarDado)
      {
      case 1:
          
            Randons();
          int  a = SomatoriaRandom;
          printf("\n");
          sleep(1);
            Randons();

          int b = SomatoriaRandom;

          if(a>b)
          {
              printf("\n O computador ganhou o turno %i\n", turno);
               PassarTurno();
               
               
          }

          else if(b>a)
          {
              printf("\nVocê ganhou o turno %i\n", turno);
               PassarTurno();
               
          }

          else
          {
              printf("\nerro\n");
               printf("Por favor jogue de novo.\n");
               PassarTurno();
               
          }

        break;

      case 2:
        DinheiroPlayer(testo);
         break;
      
      default:
        printf("\nInsira uma opçao válida!\n");
        Turno();

        break;
      }

  

}



//salva o resultado dos jogos 
void Save()
{
   FILE  *fp;

   char ler[1000];

   fp = fopen("/home/willi/Desktop/dados.dtb.txt", "w+");
     fprintf(fp, "test\n");

   fclose(fp);

   if(!fp)
   {
    printf("erro");
   }
 
}



int main()
{

    printf("Bem vindo ao jogo dos dados\n");
    printf("Digite 1 para iniciar o jogo\n");
    printf("Digite 2 para ler as regras\n");
    printf("Digite 3 para abrir o historico de jogos.\n");
    
     int escolha;
      scanf("%i", &escolha);



      
      switch (escolha)
      {
     //inicia o jogo
      case 1:
            printf("\nEscolha o modo: Jogador VS Maquina[1]\n");
             printf("Jogador vs Jogador[2]\n");
              int ModoDeJogo;
               scanf("%i", &ModoDeJogo);

                 switch(ModoDeJogo)
                 {  
                  //inicia o jogo PVPC
                    case 1:
                          DinheiroPlayer(testo);
                          printf("ok%i", Dinheiro_Pc);
                            DinheiroPc();
                            Turno();
                      break;
         
               //inicia o jogo PVP
                  case 2:
                    printf("pvp nao programado ):");
                    break;
                  
                
                default:
                        printf("\nEscolha uma das opçoes válidas!\n");
                        main();
                  break;
             }
 
        break;

      //printa as regras
      case 2:
            Regras();
             main();
        break;
 
      //abre o save
      case 3:
             Save();
        break;
      
      //opçao invalida
      default:
            printf("\nInsira uma opçao válida!\n");
            main();
        break;
      }

            
     
  return 0;
  

}







