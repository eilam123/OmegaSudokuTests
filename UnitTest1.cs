using Soduko_Omega;
using Soduko_Omega.Ants;
using Soduko_Omega.Exceptions;
using Soduko_Omega.IO;

namespace SudokuTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void simple_9x9()
        {
            // arrange 
            string input = "800000070006010053040600000000080400003000700020005038000000800004050061900002000";
            string expected = "831529674796814253542637189159783426483296715627145938365471892274958361918362547";
            Board board = new Board(input);
            AntSolver solver = new AntSolver(board, Constants.GLOBAL_PHER_UPDATE, Constants.BEST_PHER_EVAPORATION, Constants.NUM_OF_ANTS);
            Board solved = solver.Solve(Constants.LOCAL_PHER_UPDATE, Constants.GREEDINESS);
            string actual = solved.BoardToString();
            Boolean result;

            // act
            result = expected.Equals(actual);
            // assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void empty_9x9()
        {
            // arrange 
            string input = "000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            Board board = new Board(input);
            AntSolver solver = new AntSolver(board, Constants.GLOBAL_PHER_UPDATE, Constants.BEST_PHER_EVAPORATION, Constants.NUM_OF_ANTS);
            Board solved = solver.Solve(Constants.LOCAL_PHER_UPDATE, Constants.GREEDINESS);
            Boolean result;
            result = solved.IsValid();
            string actual = solved.BoardToString();

          
            // assert and act
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void simple_16x16()
        {
            // arrange 
            string input = "10023400<06000700080007003009:6;0<00:0010=0;00>0300?200>000900<0=000800:0<201?000;76000@000?005=000:05?0040800;0@0059<00100000800200000=00<580030=00?0300>80@000580010002000=9?000<406@0=00700050300<0006004;00@0700@050>0010020;1?900=002000>000>000;0200=3500<";
            string expected = "15:2349;<@6>?=78>@8=5?7<43129:6;9<47:@618=?;35>236;?2=8>75:94@<1=4>387;:5<261?@98;76412@9:>?<35=<91:=5?634@8>2;7@?259<>31;7=:68462@>;94=?1<587:37=91?235;>8:@<46583;1:<7264@=9?>?:<4>6@8=9372;152358<>:?6794;1=@:7=<@359>8;1642?;1?968=4@25<7>3:4>6@7;12:?=3589<";
            Board board = new Board(input);
            AntSolver solver = new AntSolver(board, Constants.GLOBAL_PHER_UPDATE, Constants.BEST_PHER_EVAPORATION, Constants.NUM_OF_ANTS);
            Board solved = solver.Solve(Constants.LOCAL_PHER_UPDATE, Constants.GREEDINESS);
            string actual = solved.BoardToString();
            Boolean result;

            // act
            result = expected.Equals(actual);
            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void empty_16x16()
        {
            // arrange 
            string input = "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            Board board = new Board(input);
            AntSolver solver = new AntSolver(board, Constants.GLOBAL_PHER_UPDATE, Constants.BEST_PHER_EVAPORATION, Constants.NUM_OF_ANTS);
            Board solved = solver.Solve(Constants.LOCAL_PHER_UPDATE, Constants.GREEDINESS);
            Boolean result;
            result = solved.IsValid();
            string actual = solved.BoardToString();


            // assert and act
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void simple_25x25()
        {
            // arrange 
            string input = "<:;090BA000I0E203C0FHD0>G070000I0E03C@0=06>GH900;02504E30@F0600H0<00?0100BA0000F0>G0D00?9<870A0E05I406>00:;?007000020I00F=0C03C@00>G000;01<:00A0825I00000900?0<00AE070I0F2=00@00;010BA000I40050C00=D0>090BA0004020C@H036>G9000001500F200000>00D6:00008700E0@003G0<00?18:00AE07000F=0G900?10:;AE200000=000@HD;?18:00200400500@0036>G0<B0E204F05I@0000>G0<6:;018I000000D0009<6>000800BA024000I0000090:>G0180;0AE05@H060000>G087000E25B00F=000<000800?025B04003IC0H06?100;E25B00=304@HD00000<00E250F030000600G9<0>;01870=0C006>@H<:009180B0A005IH060@0:;0007B?0E05I04F00C9<:0080B002500E0=3C40H06>00700200AE=3000HD00@0000000000=0040D0>00900;G?1000";
            string expected = "<:;?97BA185I4E2=3C@FHD6>G87BA15I4E23C@F=D6>GH9<:;?25I4E3C@F=6>GHD<:;?9187BA=3C@F6>GHD:;?9<87BA1E25I4D6>GH:;?9<7BA1825I4EF=3C@3C@H=>G9D6;?1<:7BAE825I4F6>G9D;?1<:BAE875I4F2=3C@H:;?1<BAE87I4F253C@H=D6>G97BAE8I4F25C@H=36>G9D<:;?15I4F2C@H=3>G9D6:;?1<87BAEC@HD3G9<6>?18:;BAE275I4F=>G9<6?18:;AE27BI4F=53C@HD;?18:AE27B4F=5IC@HD36>G9<BAE274F=5I@HD3C>G9<6:;?18I4F=5@HD3CG9<6>;?18:7BAE24F=3IHD6C@9<:>G?187;BAE25@HD6C9<:>G187;?AE25BI4F=3G9<:>187;?E25BA4F=3IC@HD6?187;E25BAF=3I4@HD6C>G9<:AE25BF=3I4HD6C@G9<:>;?187F=3C4D6>@H<:;G9187B?AE25IHD6>@<:;G987B?1E25IA4F=3C9<:;G87B?125IAEF=3C4@HD6>187B?25IAE=3C4FHD6>@G9<:;E25IA=3C4FD6>@H9<:;G?187B";
            Board board = new Board(input);
            AntSolver solver = new AntSolver(board, Constants.GLOBAL_PHER_UPDATE, Constants.BEST_PHER_EVAPORATION, Constants.NUM_OF_ANTS);
            Board solved = solver.Solve(Constants.LOCAL_PHER_UPDATE, Constants.GREEDINESS);
            string actual = solved.BoardToString();
            Boolean result;

            // act
            result = expected.Equals(actual);
            // assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void empty_25x25()
        {
            // arrange 
            string input = "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            Board board = new Board(input);
            AntSolver solver = new AntSolver(board, Constants.GLOBAL_PHER_UPDATE, Constants.BEST_PHER_EVAPORATION, Constants.NUM_OF_ANTS);
            Board solved = solver.Solve(Constants.LOCAL_PHER_UPDATE, Constants.GREEDINESS);
            Boolean result;
            result = solved.IsValid();
            string actual = solved.BoardToString();


            // assert and act
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BoardSizeTestException()
        {
            ConsoleInputHandler tested = new ConsoleInputHandler("0000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Assert.ThrowsException<BoardSizeException>(() => tested.ValidateInput());
        }
        [TestMethod]
        public void InvalidCharExceptionTest()
        {
            ConsoleInputHandler tested = new ConsoleInputHandler("00000000000000000000000000000000000000000000000000000000000000000000000000000000p");
            Assert.ThrowsException<InvalidCharException>(() => tested.ValidateInput());
        }
        
        
        [TestMethod]
        public void InvalidBoardExceptionTest()
        {
            Assert.ThrowsException<InvalidBoardException>(() => new Board("110000000000000000000000000000000000000000000000000000000000000000000000000000000"));
        }


    }
}
    
