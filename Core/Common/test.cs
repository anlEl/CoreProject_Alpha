public abstract class BirbirininYerineKullanilabilenEnum
    {
        public int Value { get; set; }
        public static implicit operator int(BirbirininYerineKullanilabilenEnum value) { return value.Value; }
    }
    public class GameTypes : BirbirininYerineKullanilabilenEnum
    {
        public static readonly GameTypes MultiPlayer =  new GameTypes() { Value = 0 } ;
        public static readonly GameTypes SinglePlayer = new GameTypes() { Value = 1 };
        private GameTypes()
        {

        }

        public static implicit operator int(GameTypes value) { return value.Value; }

        public static implicit operator GameTypes(int value)
        {
            if (value == 0)
                return MultiPlayer;
            else if (value == 1)
                return SinglePlayer;
            else
                throw new ArgumentOutOfRangeException();
            //return new GameTypes { Value = value };
        }



        //public static readonly EnumX MultiPlayer = 0;
        //public static readonly EnumX SinglePlayer = 1;
    }
    public class UserTypes : BirbirininYerineKullanilabilenEnum
    {
        public static readonly UserTypes Player = new UserTypes() { Value = 2 };
        public static readonly UserTypes AI = new UserTypes() { Value = 3 };
        private UserTypes()
        {

        }

        public static implicit operator int(UserTypes value) { return value.Value; }

        public static implicit operator UserTypes(int value)
        {
            if (value == 2)
                return Player;
            else if (value == 3)
                return AI;
            else
                throw new ArgumentOutOfRangeException();
            //return new GameTypes { Value = value };
        }



        //public static readonly EnumX MultiPlayer = 0;
        //public static readonly EnumX SinglePlayer = 1;
    }
    //////////////////

    public enum GameTypesEnum
    {
        MultiPlayer = 0,
        SinglePlayer = 1
    }

    ////////////////////

    public class A
    {
        GameTypesEnum member;
        GameTypes mm;
        BirbirininYerineKullanilabilenEnum membare;
        public A()
        {
            member = GameTypesEnum.MultiPlayer;
            mm = GameTypes.MultiPlayer;
            membare = GameTypes.MultiPlayer;
            membare = UserTypes.AI;
            int memVal = membare;

        }

        //public void abc(out BirbirininYerineKullanilabilenEnum x)
        //{
        //    
        //}


    }






    public interface IActionAuthorizationResult
    {
    }
    public interface IActionAuthorizer
    {
    }
    public enum ResultCauseTypeEnum     
    {
        None    = 0,
        Allow   = 1,
        Custom  = 3,
        Inherit = 4,
        Deny    = 5,
    }
    public enum ResultCauseTypeEnum2
    {
        None = 0,
        Allow = 1, 
        Deny = 5,
        Kamuran = 6
    }
    public interface IResultCauseTypeEnumType<T>
    {
        T ResultValue { get; }
    }
    public abstract class ResultCauseType
    {
        public abstract int ResultCauseTypeValue { get; }
    }
    public class NoneResultCauseType : ResultCauseType, IResultCauseTypeEnumType<ResultCauseTypeEnum>, IResultCauseTypeEnumType<ResultCauseTypeEnum2>
    {
        private const int resultValue = 0;
        public override int ResultCauseTypeValue { get { return resultValue; } }

        public ResultCauseTypeEnum ResultValue
        {
            get
            {
                return this;
            }
        }

        ResultCauseTypeEnum2 IResultCauseTypeEnumType<ResultCauseTypeEnum2>.ResultValue
        {
            get
            {
                return this;
            }
        }

       

        public static implicit operator ResultCauseTypeEnum(NoneResultCauseType d)
        {
            return (ResultCauseTypeEnum)resultValue;
        }
        public static implicit operator ResultCauseTypeEnum2(NoneResultCauseType d)
        {
            return (ResultCauseTypeEnum2)resultValue;
        }
    }
    public class AllowResultCauseType : ResultCauseType
    {
        private const int resultValue = 1;

        public override int ResultCauseTypeValue { get { return resultValue; } }
        public static implicit operator ResultCauseTypeEnum(AllowResultCauseType d)
        {
            return (ResultCauseTypeEnum)resultValue;
        }
    }
    public class CustomResultCauseType : ResultCauseType
    {
        public override int ResultCauseTypeValue { get { return 2; } }
    }
    public class InheritResultCauseType : ResultCauseType
    {
        public override int ResultCauseTypeValue { get { return 3; } }
    }
    public class DenyResultCauseType : ResultCauseType
    {
        public override int ResultCauseTypeValue { get { return 4; } }
    }
    public class KamuranResultCauseType : ResultCauseType
    {
        public override int ResultCauseTypeValue { get { return 15; } }
    }
    public abstract class RightCheckerResult
    {
        //public ResultCauseTypeEnum ResultCauseType { get; private set; }
        public ResultCauseType ResultCauseType { get; protected set; }

    }
    public class ClassicRightCheckerResult : RightCheckerResult
    {
        private ResultCauseType resultNone = new NoneResultCauseType();
        private ResultCauseType resultAllow = new AllowResultCauseType();
        private ResultCauseType resultCustom = new CustomResultCauseType();
        private ResultCauseType resultInherit = new InheritResultCauseType();
        private ResultCauseType resultDeny = new DenyResultCauseType();

        public ClassicRightCheckerResult()
        {
            base.ResultCauseType = resultNone;
        }
    }
    public class NewRightCheckerResult : RightCheckerResult
    {

    }
    public abstract class UserRightChecker<RightCheckerResultType> where RightCheckerResultType : RightCheckerResult, new() //: IActionAuthorizer
    {
        private RightCheckerResultType result = null;

        public RightCheckerResultType Check()
        {
            return result;
        }
        //
    }   
    public class ClassicRightChecker : UserRightChecker<ClassicRightCheckerResult>
    {
        public ClassicRightChecker()
        {
            this.Check()
        }
    }
