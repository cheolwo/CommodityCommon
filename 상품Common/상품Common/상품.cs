namespace 상품Common
{
    public enum 품목구분
    {
        원재료,
        부재료,
        제품,
        반제품,
        상품,
        무형상품
    }
    public class 상품
    {
        public string 품목코드 { get; set; }
        public string 품목명 { get; set; }
        public string 그룹명 { get; set; }
        public string 규격명 { get; set; }
        public string 바코드 { get; set; }
        public 품목구분 품목구분 { get; set; }  // Enum 타입으로 변경
        public string 이미지 { get; set; }  // 이미지 URL 또는 경로를 저장
    }
}
