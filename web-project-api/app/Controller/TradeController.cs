using Microsoft.AspNetCore.Mvc;
using web_project_api.app.Model;
using web_project_api.app.Repositorys;
namespace web_project_api.app.Controller;

public class TradeController : ControllerBase
    {
        private readonly ITradeRepository tradeRepository;
        public TradeController(ITradeRepository tradeRepository) {
            this.tradeRepository = tradeRepository;
        }

        [HttpPost("/trades")]
        public IActionResult addTrade([FromBody] Trade trade) {
            tradeRepository.add(trade);
            return Created($"/trades/{trade.TradeId}",trade);
        }

        [HttpPut("/trades")]
        public IActionResult updateTradeById([FromBody] Trade trade) {
            return tradeRepository.updateTrade(trade) != null ? Ok(tradeRepository.updateTrade(trade)) : NoContent();
        }
        
        [HttpDelete("/trades/{tradeId}")]
        public IActionResult deleteTradeById([FromRoute] int tradeId) {
           try {
                tradeRepository.deleteTradeById(tradeId);
                return Ok();
           } catch (Exception e) {
                Console.WriteLine($"Generic Exception Handler: {e}");
                return NotFound();
           }
        }
        
        [HttpGet("/trades/{tradeId}")]
        public IActionResult getTradeById([FromRoute] int tradeId) {
             var result = tradeRepository.getTradeById(tradeId);
            if (result != null ) {
                return Ok(tradeRepository.getTradeById(tradeId));
            } else {
                return NotFound();
            }
        }

        [HttpGet("/trades")]
        public IActionResult getTradeByRangeDate([FromQuery] DateTime startDate , [FromQuery] DateTime endDate) {
            var result = tradeRepository.searchTradeByDate(startDate,endDate);
            if ( result == null || !result.Any() ) {
                return NoContent();
            } else {
                return Ok( tradeRepository.searchTradeByDate(startDate,endDate) ); 
            }
        }
    }
